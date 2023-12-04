using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class addedPlants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "id",
                keyValue: 11);
        }
    }
}
