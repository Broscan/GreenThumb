﻿// <auto-generated />
using System;
using GreenThumb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GreenThumb.Models.GardenModel", b =>
                {
                    b.Property<int>("GardenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GardenId"), 1L, 1);

                    b.HasKey("GardenId");

                    b.ToTable("Gardens");

                    b.HasData(
                        new
                        {
                            GardenId = 1
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.InstructionModel", b =>
                {
                    b.Property<int>("InstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructionId"), 1L, 1);

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("instruction");

                    b.Property<int>("PlantId")
                        .HasColumnType("int")
                        .HasColumnName("plant_id");

                    b.HasKey("InstructionId");

                    b.HasIndex("PlantId");

                    b.ToTable("Instructions");

                    b.HasData(
                        new
                        {
                            InstructionId = 1,
                            Instruction = "Full sunlight for at least 6 hours a day.",
                            PlantId = 1
                        },
                        new
                        {
                            InstructionId = 2,
                            Instruction = "Pinch off flower buds to encourage leaf growth. Harvest regularly.",
                            PlantId = 1
                        },
                        new
                        {
                            InstructionId = 3,
                            Instruction = "Partial to full shade.",
                            PlantId = 2
                        },
                        new
                        {
                            InstructionId = 4,
                            Instruction = "Keep the soil consistently moist, especially during dry spells.",
                            PlantId = 2
                        },
                        new
                        {
                            InstructionId = 5,
                            Instruction = "Allow the soil to dry out completely between watering.",
                            PlantId = 3
                        },
                        new
                        {
                            InstructionId = 6,
                            Instruction = "Use well-draining soil. Be cautious not to overwater.",
                            PlantId = 3
                        },
                        new
                        {
                            InstructionId = 7,
                            Instruction = "Wipe leaves with a damp cloth to remove dust. Avoid overwatering.",
                            PlantId = 4
                        },
                        new
                        {
                            InstructionId = 8,
                            Instruction = "Low to moderate indirect light.",
                            PlantId = 4
                        },
                        new
                        {
                            InstructionId = 9,
                            Instruction = "Support the plant with stakes. Prune to encourage airflow and fruiting.",
                            PlantId = 5
                        },
                        new
                        {
                            InstructionId = 10,
                            Instruction = "Keep the soil consistently moist.",
                            PlantId = 5
                        },
                        new
                        {
                            InstructionId = 11,
                            Instruction = "Regular watering, and deep soakings.",
                            PlantId = 6
                        },
                        new
                        {
                            InstructionId = 12,
                            Instruction = "Prune dead or diseased branches. Fertilize during the growing season.",
                            PlantId = 6
                        },
                        new
                        {
                            InstructionId = 13,
                            Instruction = "Well-drained soil; water sparingly.",
                            PlantId = 7
                        },
                        new
                        {
                            InstructionId = 14,
                            Instruction = "Allow the foliage to die back naturally after flowering.",
                            PlantId = 7
                        },
                        new
                        {
                            InstructionId = 15,
                            Instruction = "Allow the potting mix to dry between waterings.",
                            PlantId = 8
                        },
                        new
                        {
                            InstructionId = 16,
                            Instruction = "Use orchid-specific fertilizers. Repot when needed.",
                            PlantId = 8
                        },
                        new
                        {
                            InstructionId = 17,
                            Instruction = "Regular watering.",
                            PlantId = 9
                        },
                        new
                        {
                            InstructionId = 18,
                            Instruction = "Pinch back young shoots to encourage bushiness. Deadhead spent blooms.",
                            PlantId = 9
                        },
                        new
                        {
                            InstructionId = 19,
                            Instruction = "Plant tubers in well-draining soil. Mulch to retain moisture.",
                            PlantId = 10
                        },
                        new
                        {
                            InstructionId = 20,
                            Instruction = "Keep the soil consistently moist.",
                            PlantId = 10
                        },
                        new
                        {
                            InstructionId = 21,
                            Instruction = "Allow foliage to wither naturally after flowering. Divide bulbs if needed.",
                            PlantId = 11
                        },
                        new
                        {
                            InstructionId = 22,
                            Instruction = "Well-drained soil; water during dry periods.",
                            PlantId = 11
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.PlantGarden", b =>
                {
                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("GardenId")
                        .HasColumnType("int");

                    b.HasKey("PlantId", "GardenId");

                    b.HasIndex("GardenId");

                    b.ToTable("PlantGarden");

                    b.HasData(
                        new
                        {
                            PlantId = 3,
                            GardenId = 1
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.PlantModel", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("plant_description");

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("plant_name");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            Description = "Basil is a fragrant herb with green leaves, often used in cooking for its aromatic qualities. It is a key ingredient in pesto.",
                            PlantName = "Basil"
                        },
                        new
                        {
                            PlantId = 2,
                            Description = "Rhododendrons are flowering shrubs known for their vibrant, showy clusters of flowers. They come in various colors and are often used in landscaping.",
                            PlantName = "Rhododendron"
                        },
                        new
                        {
                            PlantId = 3,
                            Description = "Cacti are succulent plants adapted to arid environments. They typically have thick, fleshy stems and are known for their ability to store water.",
                            PlantName = "Cactus"
                        },
                        new
                        {
                            PlantId = 4,
                            Description = "The Peace Lily is a popular indoor plant with glossy green leaves and distinctive white flowers. It is known for its air-purifying qualities.",
                            PlantName = "Peace Lily"
                        },
                        new
                        {
                            PlantId = 5,
                            Description = "The tomato is a red or yellowish fruit commonly used as a vegetable in cooking. It is rich in vitamins and often a key ingredient in salads and sauces.",
                            PlantName = "Tomato"
                        },
                        new
                        {
                            PlantId = 6,
                            Description = "Roses are classic flowers with a wide range of colors and fragrances. They come in various forms, such as hybrid teas, floribundas, and climbers.",
                            PlantName = "Roses"
                        },
                        new
                        {
                            PlantId = 7,
                            Description = "Tulips are spring-blooming flowers with cup-shaped petals. They come in a variety of colors and are known for their elegance and simplicity.",
                            PlantName = "Tulips"
                        },
                        new
                        {
                            PlantId = 8,
                            Description = "Orchids are diverse flowering plants with intricate and exotic blooms. They are often cultivated as indoor plants and have a wide range of species.",
                            PlantName = "Orchids"
                        },
                        new
                        {
                            PlantId = 9,
                            Description = "Chrysanthemums, or mums, are fall-blooming flowers with a variety of shapes and colors. They are often used in floral arrangements.",
                            PlantName = "Chrysanthemums"
                        },
                        new
                        {
                            PlantId = 10,
                            Description = "Ranunculus flowers have layers of delicate, paper-thin petals and come in a variety of colors. They are popular in bouquets and gardens.",
                            PlantName = "Ranunculus"
                        },
                        new
                        {
                            PlantId = 11,
                            Description = "Daffodils are spring flowers with trumpet-shaped blooms and distinctive yellow or white petals. They are a symbol of renewal and the arrival of spring.",
                            PlantName = "Daffodils"
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int?>("GardenId")
                        .HasColumnType("int")
                        .HasColumnName("garden_id");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.HasIndex("GardenId")
                        .IsUnique()
                        .HasFilter("[garden_id] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GardenId = 1,
                            Password = "BETzSRAPc3/w6srQ6jx5bw==",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("GreenThumb.Models.InstructionModel", b =>
                {
                    b.HasOne("GreenThumb.Models.PlantModel", "Plant")
                        .WithMany("Instructions")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumb.Models.PlantGarden", b =>
                {
                    b.HasOne("GreenThumb.Models.GardenModel", "Garden")
                        .WithMany("PlantGardens")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenThumb.Models.PlantModel", "Plant")
                        .WithMany("PlantGardens")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garden");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumb.Models.UserModel", b =>
                {
                    b.HasOne("GreenThumb.Models.GardenModel", "Garden")
                        .WithOne("User")
                        .HasForeignKey("GreenThumb.Models.UserModel", "GardenId");

                    b.Navigation("Garden");
                });

            modelBuilder.Entity("GreenThumb.Models.GardenModel", b =>
                {
                    b.Navigation("PlantGardens");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenThumb.Models.PlantModel", b =>
                {
                    b.Navigation("Instructions");

                    b.Navigation("PlantGardens");
                });
#pragma warning restore 612, 618
        }
    }
}
