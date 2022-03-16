using System.ComponentModel.DataAnnotations;

namespace zahranStore.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int price { get; set; }
        public int CategoryId { get; set; }
        public string Photo { get; set; }
        public Category category { get; set; }


    }
}
