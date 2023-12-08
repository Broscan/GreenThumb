using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class GreenThumbUoW
    {
        private readonly AppDbContext _context;

        public GreenThumbRepository<PlantModel> PlantRepository { get; }
        public GreenThumbRepository<InstructionModel> InstructionRepository { get; }
        public GreenThumbRepository<UserModel> UserRepository { get; set; }
        public GreenThumbRepository<GardenModel> GardenRepository { get; set; }
        public GreenThumbRepository<PlantGarden> PlantGardenRepository { get; set; }

        public GreenThumbUoW(AppDbContext context)
        {
            _context = context;

            PlantRepository = new(context);
            InstructionRepository = new(context);
            UserRepository = new(context);
            GardenRepository = new(context);
            PlantGardenRepository = new(context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
