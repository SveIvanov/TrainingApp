using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using TrainingApp.Core.Models.Hiit;
using TrainingApp.Infrastructure.Data.Models;

namespace TrainingApp.Core.Contracts
{
    public interface IHiitService
    {
        Task<IEnumerable<AllHiitModel>> TakeAllAsync();

        Task<int> CreateAsync(HiitFormModel model,int trainerId);

       
    }
}
