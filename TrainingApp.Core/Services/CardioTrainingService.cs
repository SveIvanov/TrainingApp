using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Infrastructure.Data;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Services
{
    public class CardioTrainingService : ICardioTrainingService
    {
        private readonly TrainingDbContext context;

        public CardioTrainingService(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task<int> CreateAsync(CardioTrainingFormModel model, int trainerId)
        {
            CardioTraining cardioTraining = new CardioTraining()
            {
                Type = model.Type,
                DurationInMinutes = model.Duration,
                DistanceInMeters = model.Distance,
                Date = DateTime.Parse(model.Date),
                TrainerId = trainerId
            };

            await context.CardioTrainings.AddAsync(cardioTraining);
            await context.SaveChangesAsync();

            return cardioTraining.Id;
        }

        public async Task<IEnumerable<AllCardioTrainingModel>> TakeAllAsync()
        {
            return await context.CardioTrainings
                            .Select(c => new AllCardioTrainingModel
                            {
                                Id = c.Id,
                                Type = c.Type,
                                Duration = c.DurationInMinutes,
                                Distance = c.DistanceInMeters,
                                Trainer = c.Trainer.Name,
                                Date = c.Date.ToString("yyyy/MM/dd HH:mm:ss"),
                                TrainerEmail = c.Trainer.User.UserName
                            })
                            .ToListAsync();
        }
    }
}
