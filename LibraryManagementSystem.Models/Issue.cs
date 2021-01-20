using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public int IssueDays { get; set; }
    }
}
