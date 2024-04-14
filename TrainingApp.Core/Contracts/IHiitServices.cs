using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Core.Models.Hiit;

namespace TrainingApp.Core.Contracts
{
    public interface IHiitServices
    {
        Task<IEnumerable<AllHiitModel>> TakeAll();
    }
}
