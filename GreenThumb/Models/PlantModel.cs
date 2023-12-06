using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumb.Models
{
    public class PlantModel
    {
        [Key]
        [Column("id")]
        public int PlantId { get; set; }
        [Column("plant_name")]
        public string PlantName { get; set; } = null!;
        [Column("plant_description")]
        public string? Description { get; set; }
        public List<InstructionModel> Instructions { get; set; } = new();
        public List<PlantGarden> PlantGardens { get; set; } = new();

    }
}
