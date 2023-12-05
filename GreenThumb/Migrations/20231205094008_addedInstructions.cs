using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class addedInstructions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "id",
                keyValue: 22);
        }
    }
}
