using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class BookImage
    {
        [Key]
        public int BookImageId { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
