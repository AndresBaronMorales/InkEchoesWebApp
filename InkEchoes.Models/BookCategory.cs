using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class BookCategory
    {
        [Key]
        public int BookCategoryId { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
