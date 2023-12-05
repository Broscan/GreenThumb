using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class GreenThumbUoW
    {
        private readonly AppDbContext _context;

        public GreenThumbRepository<PlantModel> PlantRepository { get; }
        public GreenThumbRepository<InstructionModel> InstructionProperty { get; }

        public GreenThumbUoW(AppDbContext context)
        {
            _context = context;

            PlantRepository = new(context);
            InstructionProperty = new(context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
