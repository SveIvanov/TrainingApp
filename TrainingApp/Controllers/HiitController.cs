using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Controllers
{
    
    public class HiitController : BaseController
    {
        private readonly IHiitService _hiitService;
        public HiitController(IHiitService hiitService)
        {
            _hiitService = hiitService;
        }
    
        public async Task<IActionResult> All()
        {
            var model = await _hiitService.TakeAllAsync();
            return View(model);
        }
    }
}
