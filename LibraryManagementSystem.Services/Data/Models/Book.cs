using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Services.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Edition { get; set; }
        [Required]
        public int NoOfCopies { get; set; }
    }
}
