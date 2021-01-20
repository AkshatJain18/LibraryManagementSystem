using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Issue
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime IssueDate { get; set; }
        public int IssueDays { get; set; }
    }
}
