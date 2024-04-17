using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Core.Contracts
{
    public interface ITrainerService
    {
        Task<bool> ExistByIDAsync(string UserId);

        Task CreateAsync(string userId, string name);

        Task<int?> GetTrainerIdAsync(string userId);
    }
}
