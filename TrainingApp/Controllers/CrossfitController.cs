using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Core.Services;
using TrainingApp.Extensions;

namespace TrainingApp.Controllers
{
    
    public class CrossfitController : BaseController
    {
        private readonly ICrossfitService _crossfitService;
        private readonly ITrainerService _trainerService;
        public CrossfitController(ICrossfitService crossfitService, ITrainerService trainerService)
        {
            _crossfitService = crossfitService;
            _trainerService = trainerService;   
        }

        public async Task<IActionResult> All()
        {
            var model = await _crossfitService.TakeAllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (await _trainerService.ExistByIDAsync(User.Id()) == false)
            {
                return RedirectToAction(nameof(TrainerController.Become), "Trainer");
            }

            var model = new CrossfitFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CrossfitFormModel model)
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

            int newCrossfirId = await _crossfitService.CreateAsync(model, trainerId ?? 0);

            return RedirectToAction(nameof(All));
        }

    }
}
