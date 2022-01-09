using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleTest
{
    class Loan
    {
        [Key]
        [Display(Name = "Loan ID")]
        public string LoanID { get; set; }

        public int MemberID { get; set; }

        public int BookID { get; set; }

        public int LoanIssueDate { get; set; }


        [ForeignKey("DoctorDSS")]
        public virtual Member Member { get; set; }

        [ForeignKey("DoctorDSS")]
        public virtual Book Book { get; set; }
    }
}
