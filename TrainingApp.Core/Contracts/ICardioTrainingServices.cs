using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Models.CardioTraining;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Core.Contracts
{
    public interface ICardioTrainingServices
    {
        Task<IEnumerable<AllCardioTrainingModel>> TakeAll();
    }
}
