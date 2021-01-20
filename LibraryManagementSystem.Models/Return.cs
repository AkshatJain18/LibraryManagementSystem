using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Return
    {
        public int Id { get; set; }
        public int IssueId { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
