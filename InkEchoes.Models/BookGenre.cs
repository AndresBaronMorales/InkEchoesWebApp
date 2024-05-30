using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class BookGenre
    {
        [Key]
        public int BookGenreId { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public int GenreId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}
