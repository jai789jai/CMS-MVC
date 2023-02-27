using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CMS.Models
{
    public partial class BookCollege
    {
        [Required(ErrorMessage="*")]
        public int BookId { get; set; }
        [Required(ErrorMessage="*")]
        public string BookName { get; set; }
        [Required(ErrorMessage="*")]
        public string Author { get; set; }
        [Required(ErrorMessage="*")]
        public string Status { get; set; }
        public string IssuedTo { get; set; }
    }
}
