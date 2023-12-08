using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class initCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gardens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plant_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plant_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    garden_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Gardens_garden_id",
                        column: x => x.garden_id,
                        principalTable: "Gardens",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plant_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Instructions_Plants_plant_id",
                        column: x => x.plant_id,
                        principalTable: "Plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantGarden",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    GardenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantGarden", x => new { x.PlantId, x.GardenId });
                    table.ForeignKey(
                        name: "FK_PlantGarden_Gardens_GardenId",
                        column: x => x.GardenId,
                        principalTable: "Gardens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantGarden_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gardens",
                column: "id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "id", "plant_description", "plant_name" },
                values: new object[,]
                {
                    { 1, "Basil is a fragrant herb with green leaves, often used in cooking for its aromatic qualities. It is a key ingredient in pesto.", "Basil" },
                    { 2, "Rhododendrons are flowering shrubs known for their vibrant, showy clusters of flowers. They come in various colors and are often used in landscaping.", "Rhododendron" },
                    { 3, "Cacti are succulent plants adapted to arid environments. They typically have thick, fleshy stems and are known for their ability to store water.", "Cactus" },
                    { 4, "The Peace Lily is a popular indoor plant with glossy green leaves and distinctive white flowers. It is known for its air-purifying qualities.", "Peace Lily" },
                    { 5, "The tomato is a red or yellowish fruit commonly used as a vegetable in cooking. It is rich in vitamins and often a key ingredient in salads and sauces.", "Tomato" },
                    { 6, "Roses are classic flowers with a wide range of colors and fragrances. They come in various forms, such as hybrid teas, floribundas, and climbers.", "Roses" },
                    { 7, "Tulips are spring-blooming flowers with cup-shaped petals. They come in a variety of colors and are known for their elegance and simplicity.", "Tulips" },
                    { 8, "Orchids are diverse flowering plants with intricate and exotic blooms. They are often cultivated as indoor plants and have a wide range of species.", "Orchids" },
                    { 9, "Chrysanthemums, or mums, are fall-blooming flowers with a variety of shapes and colors. They are often used in floral arrangements.", "Chrysanthemums" },
                    { 10, "Ranunculus flowers have layers of delicate, paper-thin petals and come in a variety of colors. They are popular in bouquets and gardens.", "Ranunculus" },
                    { 11, "Daffodils are spring flowers with trumpet-shaped blooms and distinctive yellow or white petals. They are a symbol of renewal and the arrival of spring.", "Daffodils" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "id", "instruction", "plant_id" },
                values: new object[,]
                {
                    { 1, "Full sunlight for at least 6 hours a day.", 1 },
                    { 2, "Pinch off flower buds to encourage leaf growth. Harvest regularly.", 1 },
                    { 3, "Partial to full shade.", 2 },
                    { 4, "Keep the soil consistently moist, especially during dry spells.", 2 },
                    { 5, "Allow the soil to dry out completely between watering.", 3 },
                    { 6, "Use well-draining soil. Be cautious not to overwater.", 3 },
                    { 7, "Wipe leaves with a damp cloth to remove dust. Avoid overwatering.", 4 },
                    { 8, "Low to moderate indirect light.", 4 },
                    { 9, "Support the plant with stakes. Prune to encourage airflow and fruiting.", 5 },
                    { 10, "Keep the soil consistently moist.", 5 },
                    { 11, "Regular watering, and deep soakings.", 6 },
                    { 12, "Prune dead or diseased branches. Fertilize during the growing season.", 6 },
                    { 13, "Well-drained soil; water sparingly.", 7 },
                    { 14, "Allow the foliage to die back naturally after flowering.", 7 },
                    { 15, "Allow the potting mix to dry between waterings.", 8 },
                    { 16, "Use orchid-specific fertilizers. Repot when needed.", 8 },
                    { 17, "Regular watering.", 9 },
                    { 18, "Pinch back young shoots to encourage bushiness. Deadhead spent blooms.", 9 },
                    { 19, "Plant tubers in well-draining soil. Mulch to retain moisture.", 10 },
                    { 20, "Keep the soil consistently moist.", 10 },
                    { 21, "Allow foliage to wither naturally after flowering. Divide bulbs if needed.", 11 },
                    { 22, "Well-drained soil; water during dry periods.", 11 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "garden_id", "password", "username" },
                values: new object[] { 1, 1, "Test", "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_plant_id",
                table: "Instructions",
                column: "plant_id");

            migrationBuilder.CreateIndex(
                name: "IX_PlantGarden_GardenId",
                table: "PlantGarden",
                column: "GardenId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_garden_id",
                table: "Users",
                column: "garden_id",
                unique: true,
                filter: "[garden_id] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "PlantGarden");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Gardens");
        }
    }
}
