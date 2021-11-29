using System.ComponentModel.DataAnnotations;
using System;

namespace BookingApiController.Models
{
    public class BookingModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string FullName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(400, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [StringLength(13, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string PhoneOrMobile { get; set; }

        [Required(ErrorMessage = "The date must be a DateTime data type.")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "The time must be a DateTime data type.")]
        [DataType(DataType.DateTime)]
        public TimeSpan Time { get; set; }

        [Required]
        [Range(1,255,
        ErrorMessage = "Value for SqlCommandType is between 0 and 1.")]
        public int Persons { get; set; }

        [DataType(DataType.Text)]
        [StringLength(65535, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Message { get; set; }
    }
}