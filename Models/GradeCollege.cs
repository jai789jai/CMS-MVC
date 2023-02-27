using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CMS.Models
{
    public partial class GradeCollege
    {
        [Required(ErrorMessage="*"),RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage="*")]
        public string Subject { get; set; }
        [Required(ErrorMessage="*")]
        public string Grade { get; set; }

        public virtual StudentCollege EmailNavigation { get; set; }
    }
}
