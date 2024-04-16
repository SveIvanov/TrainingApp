using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    
    public class CardioTrainingController : BaseController
    {
        private readonly ICardioTrainingService _cardioTrainingService;

        public CardioTrainingController(ICardioTrainingService cardioTrainingService)
        {
            _cardioTrainingService = cardioTrainingService;   
        }

        public async Task<IActionResult> All()
        {
            var model = await _cardioTrainingService.TakeAll();
            return View(model);
        }
    }
}
