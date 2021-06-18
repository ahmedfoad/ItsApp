using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using ItsApp.EntityFrameworkCore;
using ItsApp.EntityFrameworkCore.Repositories;
using ItsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ItsApp.Informations
{
    public class InformationRepository : ItsAppRepositoryBase<Models.Information>, IInformationRepository
    {
        public InformationRepository(IDbContextProvider<ItsAppDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<List<Models.Information>> GetByStepIndexAsync(int stepIndex)
        {
            return await (await GetAllAsync()).Where(a => a.StepIndex == stepIndex).OrderByDescending(a=>a.Id).ToListAsync();
        }

        public async Task<int> CreateOrUpdateAsync(Models.Information information)
        {
            return await InsertOrUpdateAndGetIdAsync(information);
        }

        public async Task DeleteAsync(int id) => await base.DeleteAsync(id);

        public async Task DeleteByStepIndexAsync(int stepIndex)
        {
            await base.DeleteAsync(a=>a.StepIndex == stepIndex);
        }

        public async Task<List<int>> GetStepIndexListAsync()
        {
            return await (await GetAllAsync()).OrderBy(a=>a.StepIndex).Select(a => a.StepIndex).Distinct().ToListAsync();
        }
    }
}
