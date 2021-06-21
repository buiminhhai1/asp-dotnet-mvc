using System;
using System.ComponentModel.DataAnnotations;
using Labo2ASPdotNet.Models.Entities;

namespace Labo2ASPdotNet.Models
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Role Role { get; set; }
    }
}
