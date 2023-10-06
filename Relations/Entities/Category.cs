using System.ComponentModel.DataAnnotations;

namespace Relations.Entities
{
    public class CategoryProduct
    {

        public int Id { get; set; }

        [Required]

        public string? Name { get; set; }


        public ICollection<ProductCategory> ProductCategory { get; set; }

    }
}
