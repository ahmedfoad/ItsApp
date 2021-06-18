using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItsApp.Models;

namespace ItsApp.Informations.Dtos
{
    [AutoMap(typeof(Information))]
    public class InformationDto : EntityDto<int>
    {
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Required]
        public int StepIndex { get; set; }
    }
}
