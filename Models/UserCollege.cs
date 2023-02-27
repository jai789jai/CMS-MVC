using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CMS.Models
{
    public partial class UserCollege
    {
        [Required(ErrorMessage="*"),RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage="*")]
        public string Name { get; set; }
        [Required(ErrorMessage="*")]
        public string Password { get; set; }

        public string Phone { get; set; }
        [Required(ErrorMessage="*")]
        public string Type { get; set; }
    }
}
