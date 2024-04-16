using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Models.Crossfit;

namespace TrainingApp.Core.Contracts
{
    public interface ICrossfitService
    {
        Task<IEnumerable<AllCrossfitModel>> TakeAllAsync();
    }
}
