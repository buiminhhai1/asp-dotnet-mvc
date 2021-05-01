using System;
using System.ComponentModel.DataAnnotations;

namespace Labo2ASPdotNet.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
