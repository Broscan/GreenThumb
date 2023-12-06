using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumb.Models
{
    public class GardenModel
    {
        [Key]
        [Column("id")]
        public int GardenId { get; set; }
        [Column("garden_name")]
        public string GardenName { get; set; } = null!;
        public List<PlantGarden> PlantGardens { get; set; } = new();
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public UserModel? User { get; set; }

    }
}
