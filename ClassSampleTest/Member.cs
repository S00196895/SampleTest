using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleTest
{
    class Member
    {
        [Key]
        [Display(Name = "Member ID")]
        public string MemberID { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }
    }
}
