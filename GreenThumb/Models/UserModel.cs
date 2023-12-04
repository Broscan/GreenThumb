using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumb.Models
{
    public class UserModel
    {
        [Key]
        [Column("id")]
        public int UserId { get; set; }
        [Column("username")]
        public string? UserName { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        public int GardenId { get; set; }
        public GardenModel Garden { get; set; } = null!;
    }
}
