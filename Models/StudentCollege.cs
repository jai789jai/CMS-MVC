using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CMS.Models
{
    public partial class StudentCollege
    {
        public StudentCollege()
        {
            GradeColleges = new HashSet<GradeCollege>();
        }

        [Required(ErrorMessage="*"),RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage="*")]
        public string Name { get; set; }
        [Required(ErrorMessage="*"),DataType(DataType.DateTime)]
        public DateTime? Birthdate { get; set; }
        [Required(ErrorMessage="*")]
        public int? Rollno { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage="*")]
        public string Degree { get; set; }
        [Required(ErrorMessage="*")]
        public string Department { get; set; }
        [Required(ErrorMessage="*")]
        public int? Batch { get; set; }
        [Required(ErrorMessage="*"),Range(0,10,ErrorMessage="Please enter correct value")]
        public decimal? Cgpa { get; set; }

        public virtual ICollection<GradeCollege> GradeColleges { get; set; }
    }
}
