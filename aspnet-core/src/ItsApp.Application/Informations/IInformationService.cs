using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using ItsApp.Informations.Dtos;

namespace ItsApp.Informations
{
    public interface IInformationService : IApplicationService
    {
        Task<int> CreateOrUpdateAsync(InformationDto information);
        Task<InformationDto> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<List<InformationDto>> GetByStepIndexAsync(int stepIndex);
        Task DeleteByStepIndexAsync(int stepIndex);
        Task<List<int>> GetStepIndexListAsync();
    }
}
