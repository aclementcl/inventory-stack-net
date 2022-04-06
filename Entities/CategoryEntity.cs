using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(50)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
