using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class BooksAuthors
    {
        [Key]
        public int BooksAuthorsId { get; set; }

        public string BookId { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
