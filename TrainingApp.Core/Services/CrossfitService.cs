using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Crossfit;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Infrastructure.Data;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Services
{
    public class CrossfitService : ICrossfitService
    {
        private readonly TrainingDbContext context;

        public CrossfitService(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task<int> CreateAsync(CrossfitFormModel model, int trainerId)
        {
            Crossfit crossfit = new Crossfit()
            {
                
                DurationInMinutes = model.Duration,
                Date = DateTime.Parse(model.Date),
                TrainerId = trainerId
            };

            await context.Crossfits.AddAsync(crossfit);
            await context.SaveChangesAsync();

            return crossfit.Id;
        }

        public async Task<IEnumerable<AllCrossfitModel>> TakeAllAsync()
        {
            return await context.Crossfits
                            .Select(c => new AllCrossfitModel
                            {
                                Id = c.Id,
                                Duration = c.DurationInMinutes,
                                Trainer = c.Trainer.Name,
                                Date = c.Date.ToString("yyyy/MM/dd HH:mm:ss"),
                                TrainerEmail = c.Trainer.User.UserName
                            })
                            .ToListAsync();
        }
    }
}
