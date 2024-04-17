using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Extensions;

namespace TrainingApp.Controllers
{
    
    public class HiitController : BaseController
    {
        private readonly IHiitService _hiitService;
        private readonly ITrainerService _trainerService;

        public HiitController(IHiitService hiitService,ITrainerService trainerService)
        {
            _hiitService = hiitService;
            _trainerService = trainerService;
        }
    
        public async Task<IActionResult> All()
        {
            var model = await _hiitService.TakeAllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (await _trainerService.ExistByIDAsync(User.Id()) == false)
            {
                return RedirectToAction(nameof(TrainerController.Become), "Trainer");
            }

            var model = new HiitFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(HiitFormModel model)
        {
            if (await _trainerService.ExistByIDAsync(User.Id()) == false)
            {
                return RedirectToAction(nameof(TrainerController.Become), "Trainer");
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            int? trainerId = await _trainerService.GetTrainerIdAsync(User.Id());

            int newHiitId = await _hiitService.CreateAsync(model, trainerId ?? 0);

            return RedirectToAction(nameof(All));
        }
    }
}
