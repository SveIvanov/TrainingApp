using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Contracts;
using TrainingApp.Infrastructure.Data;

namespace TrainingApp.Core.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly TrainingDbContext context;

        public TrainerService(TrainingDbContext _context)
        {
            context = _context;
        }

        public Task CreateAsync(string userId, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistByIDAsync(string userId)
        {
            return await context.Trainers
                        .AnyAsync(t => t.UserId == userId);
        }
    }
}
