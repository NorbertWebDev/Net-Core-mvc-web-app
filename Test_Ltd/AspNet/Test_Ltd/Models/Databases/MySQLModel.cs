using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;

namespace MySqlModel.Models
{
    public class MySqlModel
    {
        [Required(ErrorMessage = "Connection MySqlConnection is required.")]
        [DataType(DataType.Custom)]
        public MySqlConnection Connection { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(105, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string SqlCommand { get; set; }

        [Required(ErrorMessage = "Connection MySqlCommand is required.")]
        [DataType(DataType.Custom)]
        public MySqlCommand RunSql { get; set; }
    }
}