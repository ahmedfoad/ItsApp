using System.ComponentModel.DataAnnotations;

namespace ItsApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}