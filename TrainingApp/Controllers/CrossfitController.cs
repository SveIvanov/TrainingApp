using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class CrossfitController : Controller
    {
        public async Task<IActionResult> All()
        {
            var model = new AllCrossfitModel();
            return View(model);
        }
    }
}
