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

namespace TrainingApp.Core.Services
{
    public class CrossfitServices : ICrossfitServices
    {
        private readonly TrainingDbContext context;

        public CrossfitServices(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<AllCrossfitModel>> TakeAll()
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
