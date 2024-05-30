using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class BookLanguage
    {
        [Key]
        public int BookLanguageId { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }
    }
}
