using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Core.Models.StrenghtTraining;
using TrainingApp.Infrastructure.Data;

namespace TrainingApp.Core.Services
{
    public class StrenghtTrainingService : IStrenghtTrainingService
    {
        private readonly TrainingDbContext context;

        public StrenghtTrainingService(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<AllStrenghtTrainingModel>> TakeAllAsync()
        {
            return await context.StrenghtTrainings
                             .Select(s => new AllStrenghtTrainingModel
                             {
                                 Id = s.Id,
                                 BodyPart = s.BodyPart,
                                 Duration = s.DurationInMinutes,
                                 Sets = s.Sets,
                                 Trainer = s.Trainer.Name,
                                 Date = s.Date.ToString("yyyy/MM/dd HH:mm:ss"),
                                 TrainerEmail = s.Trainer.User.UserName
                             })
                             .ToListAsync();
        }
    }
}
