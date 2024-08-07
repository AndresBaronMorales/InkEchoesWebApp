﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InkEchoes.Models
{
    public class Book
    {
        [Key]
        public string BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int NumberPages { get; set; }
        public string? Origin { get; set; }

        [Required]
        public string Editorial { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
