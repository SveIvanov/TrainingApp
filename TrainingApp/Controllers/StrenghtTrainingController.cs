using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.StrenghtTraining;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class StrenghtTrainingController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new AllStrenghtTrainingModel();
            return View(model);
        }
    }
}
