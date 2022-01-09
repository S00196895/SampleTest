using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleTest
{
    class Book
    {
        [Key]
        [Display(Name = "Book ID")]
        public string BookID { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }
        public string Author { get; set; }
        public enum LoanType { Restricted, General }
        public int LoanDuration { get; set; }
    }
}
