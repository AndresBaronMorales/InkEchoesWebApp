using System.ComponentModel.DataAnnotations;

namespace InkEchoes.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        public string LanguageName { get; set; }
    }
}
