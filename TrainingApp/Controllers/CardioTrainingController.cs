using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class CardioTrainingController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new AllCardioTrainingModel();
            return View(model);
        }
    }
}
