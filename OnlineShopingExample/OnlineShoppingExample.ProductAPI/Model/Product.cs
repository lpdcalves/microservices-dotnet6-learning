using OnlineShoppingExample.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingExample.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(1000)]
        public string? Description { get; set; }

        [Column("category_name")]
        [StringLength(100)]
        public string? CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string? ImageURL { get; set; }
    }
}
