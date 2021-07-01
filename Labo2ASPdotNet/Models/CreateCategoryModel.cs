using System;
using System.ComponentModel.DataAnnotations;

namespace Labo2ASPdotNet.Models
{
    public class CreateCategoryModel
    {
        [Required]
        public string Name { get; set; }
    }
}
