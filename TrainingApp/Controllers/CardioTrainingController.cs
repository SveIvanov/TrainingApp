using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class CardioTrainingController : Controller
    {
        private readonly ICardioTrainingServices _cardioTrainingServices;

        public CardioTrainingController(ICardioTrainingServices cardioTrainingServices)
        {
            _cardioTrainingServices = cardioTrainingServices;   
        }

        public async Task<IActionResult> All()
        {
            var model = await _cardioTrainingServices.TakeAll();
            return View(model);
        }
    }
}
