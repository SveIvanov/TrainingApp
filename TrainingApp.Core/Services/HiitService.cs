using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Infrastructure.Data;

namespace TrainingApp.Core.Services
{
    public class HiitService : IHiitService
    {
        private readonly TrainingDbContext context;

        public HiitService(TrainingDbContext _context)
        {
            context = _context;
        }
        
        public async Task<IEnumerable<AllHiitModel>> TakeAll()
        {
            return await context.Hiits
                   .Select(h => new AllHiitModel
                   {
                       Id = h.Id,
                       Type = h.Type,
                       Duration = h.DurationInMinutes,
                       Intervals = h.Intervals,
                       Trainer = h.Trainer.Name,
                       Date = h.Date.ToString("yyyy/MM/dd HH:mm:ss"),
                       TrainerEmail = h.Trainer.User.UserName
                   })
                   .ToListAsync();
        }
    }
}
