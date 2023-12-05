using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class GreenThumbUoW
    {
        private readonly AppDbContext _context;

        public GreenThumbRepository<PlantModel> PlantRepository { get; }
        public GreenThumbRepository<InstructionModel> InstructionRepository { get; }

        public GreenThumbUoW(AppDbContext context)
        {
            _context = context;

            PlantRepository = new(context);
            InstructionRepository = new(context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
