using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.ObjectMapping;
using Castle.Core.Logging;
using ItsApp.Informations.Dtos;
using ItsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItsApp.Informations
{
    [AbpAuthorize]
    public class InformationService : IInformationService
    {
        private readonly IInformationRepository _informationRepository;
        private readonly IObjectMapper _objectMapper;
        public ILogger Logger { get; set; }

        public InformationService(IInformationRepository informationRepository, IObjectMapper objectMapper)
        {
            _informationRepository = informationRepository;
            _objectMapper = objectMapper;
            Logger = NullLogger.Instance;
        }
        [HttpGet]
        public async Task<List<int>> GetStepIndexListAsync()
        {
            return await _informationRepository.GetStepIndexListAsync();
        }

        [HttpGet]
        public async Task<List<InformationDto>> GetByStepIndexAsync(int stepIndex)
        {
            var informations = await _informationRepository.GetByStepIndexAsync(stepIndex);
            return _objectMapper.Map<List<InformationDto>>(informations);
        }

        [HttpPut]
        public async Task<int> CreateOrUpdateAsync(InformationDto informationDto)
        {
            var information = _objectMapper.Map<Information>(informationDto);
            return await _informationRepository.CreateOrUpdateAsync(information);
        }

        public async Task<InformationDto> GetAsync(int id)
        {
            var information = await _informationRepository.GetAsync(id);
            return _objectMapper.Map<InformationDto>(information);
        }

        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _informationRepository.DeleteAsync(id);
        }

        [HttpDelete]
        public async Task DeleteByStepIndexAsync(int stepIndex)
        {
            await _informationRepository.DeleteByStepIndexAsync(stepIndex);
        }
    }
}
