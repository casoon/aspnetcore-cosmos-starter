using System;
namespace Starter.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Name = "";
        }

        public String Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
