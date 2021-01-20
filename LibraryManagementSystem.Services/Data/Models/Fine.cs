using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Services.Data.Models
{
    public class Fine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int IssueId { get; set; }
        [Required]
        public int ReturnId { get; set; }
        [Required]
        public int OverDueDays { get; set; }
        [Required]
        public decimal FineAmount { get; set; }
    }
}
