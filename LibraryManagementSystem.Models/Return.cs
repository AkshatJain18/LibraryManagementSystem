using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Return
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IssueId { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}
