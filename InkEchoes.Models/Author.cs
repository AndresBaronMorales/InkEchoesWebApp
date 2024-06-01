using System.ComponentModel.DataAnnotations;

namespace InkEchoes.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateOnly Birthdate { get; set; }

        [Required]
        public string Nacionality { get; set; }
    }
}
