using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsApp.Models
{
    public interface IInformationRepository
    {
        Task<int> CreateOrUpdateAsync(Information information);
        Task<Information> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<List<Information>> GetByStepIndexAsync(int stepIndex);
        Task DeleteByStepIndexAsync(int stepIndex);
        Task<List<int>> GetStepIndexListAsync();
    }
}
