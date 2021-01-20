using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipEndDate { get; set; }
    }
}
