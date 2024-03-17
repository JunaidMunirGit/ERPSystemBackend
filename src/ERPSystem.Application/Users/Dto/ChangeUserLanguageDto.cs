using System.ComponentModel.DataAnnotations;

namespace ERPSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}