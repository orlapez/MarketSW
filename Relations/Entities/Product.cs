using System.ComponentModel.DataAnnotations;

namespace Relations.Entities
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        public ICollection<ProductCategory> ProductCategory{ get; set;}



    }
}
