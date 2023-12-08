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

            modelBuilder.Entity<UserModel>().HasData(
                new UserModel()
                {
                    UserId = 1,
                    UserName = "Test",
                    Password = "Test",
                    GardenId = 1
                });

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
                    PlantId = 1,
                    Instruction = "Full sunlight for at least 6 hours a day.",
                    InstructionId = 1,
                },

                new InstructionModel()
                {
                    PlantId = 1,
                    Instruction = "Pinch off flower buds to encourage leaf growth. Harvest regularly.",
                    InstructionId = 2,
                },

                new InstructionModel()
                {
                    PlantId = 2,
                    Instruction = "Partial to full shade.",
                    InstructionId = 3,
                },

                new InstructionModel()
                {
                    PlantId = 2,
                    Instruction = "Keep the soil consistently moist, especially during dry spells.",
                    InstructionId = 4,
                },

                new InstructionModel()
                {
                    PlantId = 3,
                    Instruction = "Allow the soil to dry out completely between watering.",
                    InstructionId = 5,
                },

                new InstructionModel()
                {
                    PlantId = 3,
                    Instruction = "Use well-draining soil. Be cautious not to overwater.",
                    InstructionId = 6,
                },

                new InstructionModel()
                {
                    PlantId = 4,
                    Instruction = "Wipe leaves with a damp cloth to remove dust. Avoid overwatering.",
                    InstructionId = 7,
                },

                new InstructionModel()
                {
                    PlantId = 4,
                    Instruction = "Low to moderate indirect light.",
                    InstructionId = 8,
                },

                new InstructionModel()
                {
                    PlantId = 5,
                    Instruction = "Support the plant with stakes. Prune to encourage airflow and fruiting.",
                    InstructionId = 9,
                },

                new InstructionModel()
                {
                    PlantId = 5,
                    Instruction = "Keep the soil consistently moist.",
                    InstructionId = 10,
                },

                new InstructionModel()
                {
                    PlantId = 6,
                    Instruction = "Regular watering, and deep soakings.",
                    InstructionId = 11,
                },

                new InstructionModel()
                {
                    PlantId = 6,
                    Instruction = "Prune dead or diseased branches. Fertilize during the growing season.",
                    InstructionId = 12,
                },

                new InstructionModel()
                {
                    PlantId = 7,
                    Instruction = "Well-drained soil; water sparingly.",
                    InstructionId = 13,
                },

                new InstructionModel()
                {
                    PlantId = 7,
                    Instruction = "Allow the foliage to die back naturally after flowering.",
                    InstructionId = 14,
                },

                new InstructionModel()
                {
                    PlantId = 8,
                    Instruction = "Allow the potting mix to dry between waterings.",
                    InstructionId = 15,
                },

                new InstructionModel()
                {
                    PlantId = 8,
                    Instruction = "Use orchid-specific fertilizers. Repot when needed.",
                    InstructionId = 16,
                },

                new InstructionModel()
                {
                    PlantId = 9,
                    Instruction = "Regular watering.",
                    InstructionId = 17,
                },

                new InstructionModel()
                {
                    PlantId = 9,
                    Instruction = "Pinch back young shoots to encourage bushiness. Deadhead spent blooms.",
                    InstructionId = 18,
                },

                new InstructionModel()
                {
                    PlantId = 10,
                    Instruction = "Plant tubers in well-draining soil. Mulch to retain moisture.",
                    InstructionId = 19,
                },

                new InstructionModel()
                {
                    PlantId = 10,
                    Instruction = "Keep the soil consistently moist.",
                    InstructionId = 20,
                },

                new InstructionModel()
                {
                    PlantId = 11,
                    Instruction = "Allow foliage to wither naturally after flowering. Divide bulbs if needed.",
                    InstructionId = 21,
                },

                new InstructionModel()
                {
                    PlantId = 11,
                    Instruction = "Well-drained soil; water during dry periods.",
                    InstructionId = 22,
                });

            modelBuilder.Entity<GardenModel>().HasData(
                new GardenModel()
                {
                    GardenId = 1,

                });

            modelBuilder.Entity<PlantGarden>().HasData(
                new PlantGarden()
                {
                    GardenId = 1,
                    PlantId = 3
                });





        }

    }
}
