using System.ComponentModel.DataAnnotations;

namespace JiraDashboard.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}