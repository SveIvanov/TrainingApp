using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    [Authorize]
    public class HiitController : Controller
    {
        private readonly IHiitServices _hiitServices;
        public HiitController(IHiitServices hiitServices)
        {
            _hiitServices = hiitServices;
        }
    
        public async Task<IActionResult> All()
        {
            var model = await _hiitServices.TakeAll();
            return View(model);
        }
    }
}
