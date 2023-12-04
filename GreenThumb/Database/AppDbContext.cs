using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public DbSet<PlantModel> Plants { get; set; }
        public DbSet<GardenModel> Gardens { get; set; }
        public DbSet<InstructionModel> Instructions { get; set; }
        public DbSet<PlantGarden> PlantGarden { get; set; }
        public DbSet<UserModel> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GreenThumbDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlantModel>().HasMany(p => p.Instructions).WithOne(p => p.Plant).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlantGarden>().HasKey(pg => new { pg.PlantId, pg.GardenId });

            modelBuilder.Entity<PlantModel>().HasData(
                new PlantModel()
                {
                    PlantId = 1,
                    PlantName = "Basil",
                    Description = "Basil is a fragrant herb with green leaves, often used in cooking for its aromatic qualities. It is a key ingredient in pesto."
                },
                new PlantModel()
                {
                    PlantId = 2,
                    PlantName = "Rhododendron",
                    Description = "Rhododendrons are flowering shrubs known for their vibrant, showy clusters of flowers. They come in various colors and are often used in landscaping."
                },
                new PlantModel()
                {
                    PlantId = 3,
                    PlantName = "Cactus",
                    Description = "Cacti are succulent plants adapted to arid environments. They typically have thick, fleshy stems and are known for their ability to store water."
                },
                new PlantModel()
                {
                    PlantId = 4,
                    PlantName = "Peace Lily",
                    Description = "The Peace Lily is a popular indoor plant with glossy green leaves and distinctive white flowers. It is known for its air-purifying qualities."
                },
                new PlantModel()
                {
                    PlantId = 5,
                    PlantName = "Tomato",
                    Description = "The tomato is a red or yellowish fruit commonly used as a vegetable in cooking. It is rich in vitamins and often a key ingredient in salads and sauces."
                },
                new PlantModel()
                {
                    PlantId = 6,
                    PlantName = "Roses",
                    Description = "Roses are classic flowers with a wide range of colors and fragrances. They come in various forms, such as hybrid teas, floribundas, and climbers."

                },
                new PlantModel()
                {
                    PlantId = 7,
                    PlantName = "Tulips",
                    Description = "Tulips are spring-blooming flowers with cup-shaped petals. They come in a variety of colors and are known for their elegance and simplicity."
                },
                new PlantModel()
                {
                    PlantId = 8,
                    PlantName = "Orchids",
                    Description = "Orchids are diverse flowering plants with intricate and exotic blooms. They are often cultivated as indoor plants and have a wide range of species."
                },
                new PlantModel()
                {
                    PlantId = 9,
                    PlantName = "Chrysanthemums",
                    Description = "Chrysanthemums, or mums, are fall-blooming flowers with a variety of shapes and colors. They are often used in floral arrangements."
                },
                new PlantModel()
                {
                    PlantId = 10,
                    PlantName = "Ranunculus",
                    Description = "Ranunculus flowers have layers of delicate, paper-thin petals and come in a variety of colors. They are popular in bouquets and gardens."
                },
                new PlantModel()
                {
                    PlantId = 11,
                    PlantName = "Daffodils",
                    Description = "Daffodils are spring flowers with trumpet-shaped blooms and distinctive yellow or white petals. They are a symbol of renewal and the arrival of spring."
                });

            modelBuilder.Entity<InstructionModel>().HasData(
                new InstructionModel()
                {

                });
        }

    }
}
