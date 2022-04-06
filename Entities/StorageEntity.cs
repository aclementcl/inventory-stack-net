using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public ICollection<WherehouseEntity> Wherehouses { get; set; }
        public ICollection<InputOutputEntity> InOuts { get; set; }
    }
}
