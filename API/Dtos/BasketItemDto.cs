using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(minimum:0.1,double.MaxValue,ErrorMessage ="Price must be greater then 0.1")]
        public decimal Price { get; set; }
        [Required]
        [Range(1,double.MaxValue,ErrorMessage ="Item Qunatity must be atleat 1")]
        public int Quantity { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        [Required]
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}