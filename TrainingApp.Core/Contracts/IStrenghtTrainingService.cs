using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Core.Models.StrenghtTraining;

namespace TrainingApp.Core.Contracts
{
    public interface IStrenghtTrainingService
    {
        Task<IEnumerable<AllStrenghtTrainingModel>> TakeAll();
    }
}
