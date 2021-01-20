using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagementSystem.Models.Core
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfBooks { get; set; }
    }
}
