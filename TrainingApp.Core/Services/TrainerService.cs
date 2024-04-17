using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Infrastructure.Data;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly TrainingDbContext context;

        public TrainerService(TrainingDbContext _context)
        {
            context = _context;
        }

        public async Task CreateAsync(string userId, string name)
        {
            await context.Trainers.AddAsync(new Trainer()
            {
                UserId = userId,
                Name = name
            });

            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistByIDAsync(string userId)
        {
            return await context.Trainers
                        .AnyAsync(t => t.UserId == userId);
        }

        public async Task<int?> GetTrainerIdAsync(string userId)
        {
            return (await context.Trainers
                .FirstOrDefaultAsync(t => t.UserId == userId))?.Id;
        }
    }
}
