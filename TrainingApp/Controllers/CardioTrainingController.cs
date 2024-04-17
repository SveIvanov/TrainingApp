using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Core.Services;
using TrainingApp.Extensions;

namespace TrainingApp.Controllers
{
    
    public class CardioTrainingController : BaseController
    {
        private readonly ICardioTrainingService _cardioTrainingService;
        private readonly ITrainerService _trainerService;

        public CardioTrainingController(ICardioTrainingService cardioTrainingService,ITrainerService trainerService)
        {
            _cardioTrainingService = cardioTrainingService;
            _trainerService = trainerService;
        }

        public async Task<IActionResult> All()
        {
            var model = await _cardioTrainingService.TakeAllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (await _trainerService.ExistByIDAsync(User.Id()) == false)
            {
                return RedirectToAction(nameof(TrainerController.Become), "Trainer");
            }

            var model = new CardioTrainingFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CardioTrainingFormModel model)
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

            int newCardioTrId = await _cardioTrainingService.CreateAsync(model, trainerId ?? 0);

            return RedirectToAction(nameof(All));
        }
    }
}
