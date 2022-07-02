using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidProject.Models
{
    public class member
    {

        [Required(ErrorMessage = "Please give your name")]
        public string Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Name must be less than 10")]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}