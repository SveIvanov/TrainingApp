using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Infrastructure.Data;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Services
{
    public class HiitService : IHiitService
    {
        private readonly TrainingDbContext context;

        public HiitService(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task<int> CreateAsync(HiitFormModel model,int trainerId)
        {
            Hiit hiit = new Hiit()
            {
                Type = model.Type,
                DurationInMinutes = model.Duration,
                Intervals = model.Intervals,
                Date = DateTime.Parse(model.Date),
                TrainerId = trainerId
            };

            await context.Hiits.AddAsync(hiit);
            await context.SaveChangesAsync();

            return hiit.Id;
        }

        public async Task<IEnumerable<AllHiitModel>> TakeAllAsync()
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
