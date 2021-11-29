using System.ComponentModel.DataAnnotations;

namespace MenuController.Models
{
    public class MenuModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(128, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string ImageUrl { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string FoodName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(400, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Ingredients  { get; set; }

        [Required]
        [Range(0,10000000,
        ErrorMessage = "Value for SqlCommandType is between 0 and 10000000.")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(9, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Type { get; set; }
    }
}