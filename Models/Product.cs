using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(30, MinimumLength= 3, ErrorMessage ="Name has to be between 3 and 30 letters")]
        public string Name { get; set; }
        [Range(1, 1000000)]

        [Required(ErrorMessage = "Product price is required")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        public string Category { get; set; }
       
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
