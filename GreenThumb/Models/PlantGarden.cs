namespace GreenThumb.Models
{
    public class PlantGarden
    {
        public int PlantId { get; set; }
        public int GardenId { get; set; }
        public PlantModel Plant { get; set; } = null!;
        public GardenModel Garden { get; set; } = null!;
    }
}
