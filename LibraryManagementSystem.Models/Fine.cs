using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Fine
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int IssueId { get; set; }
        public int ReturnId { get; set; }
        public int OverDueDays { get; set; }
        public decimal FineAmount { get; set; }
    }
}
