using System;
namespace Labo2ASPdotNet.Models.Entities
{
    public abstract class BaseEntity
    {
        
        public DateTime CreatedAt { get; set; }

     
        public DateTime UpdatedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
