using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class CrossfitController : Controller
    {
        private readonly ICrossfitServices _crossfitServices;
        public CrossfitController(ICrossfitServices crossfitServices)
        {
            _crossfitServices = crossfitServices;
        }

        public async Task<IActionResult> All()
        {
            var model = await _crossfitServices.TakeAll();
            return View(model);
        }
    }
}
