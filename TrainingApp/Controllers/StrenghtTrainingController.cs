using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.StrenghtTraining;
using TrainingApp.Extensions;

namespace TrainingApp.Controllers
{

    public class StrenghtTrainingController : BaseController
    {
        private readonly IStrenghtTrainingService _strenghtTrainingService;
        private readonly ITrainerService _trainerService;

        public StrenghtTrainingController(IStrenghtTrainingService strenghtTrainingService,ITrainerService trainerService)
        {
            _strenghtTrainingService = strenghtTrainingService;
            _trainerService = trainerService;
        }
        
        public async Task<IActionResult> All()
        {
            var model = await _strenghtTrainingService.TakeAllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (await _trainerService.ExistByIDAsync(User.Id()) == false)
            {
                return RedirectToAction(nameof(TrainerController.Become), "Trainer");
            }

            var model = new StrenghtTrainingFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StrenghtTrainingFormModel model)
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

            int newStrenghtTrId = await _strenghtTrainingService.CreateAsync(model, trainerId ?? 0);

            return RedirectToAction(nameof(All));
        }
    }
}
