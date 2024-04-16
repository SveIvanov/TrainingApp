using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    
    public class CrossfitController : BaseController
    {
        private readonly ICrossfitService _crossfitService;
        public CrossfitController(ICrossfitService crossfitService)
        {
            _crossfitService = crossfitService;
        }

        public async Task<IActionResult> All()
        {
            var model = await _crossfitService.TakeAll();
            return View(model);
        }
    }
}
