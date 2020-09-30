using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarshallDennehey.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "This is rquired field")]
        [MaxLength(20, ErrorMessage = "More than 20 characters")]
        [EmailAddress(ErrorMessage ="Not valid email")]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

    }
}