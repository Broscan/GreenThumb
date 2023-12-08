using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class addedPlantToGarden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlantGarden",
                columns: new[] { "GardenId", "PlantId" },
                values: new object[] { 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlantGarden",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 3 });
        }
    }
}
