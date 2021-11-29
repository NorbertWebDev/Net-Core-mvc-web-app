using System.ComponentModel.DataAnnotations;

namespace ContactApiController.Models
{
    public class ContactModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string FullName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(400, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(65535, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Message { get; set; }
    }
}