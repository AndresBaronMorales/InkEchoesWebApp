using System.ComponentModel.DataAnnotations;

namespace InkEchoes.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}
