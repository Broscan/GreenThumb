using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class addedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Gardens_GardenId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GardenId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "GardenId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Gardens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "GardenId", "password", "username" },
                values: new object[] { 1, null, "Test", "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GardenId",
                table: "Users",
                column: "GardenId");

            migrationBuilder.CreateIndex(
                name: "IX_Gardens_UserId",
                table: "Gardens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gardens_Users_UserId",
                table: "Gardens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Gardens_GardenId",
                table: "Users",
                column: "GardenId",
                principalTable: "Gardens",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gardens_Users_UserId",
                table: "Gardens");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Gardens_GardenId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GardenId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Gardens_UserId",
                table: "Gardens");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Gardens");

            migrationBuilder.AlterColumn<int>(
                name: "GardenId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GardenId",
                table: "Users",
                column: "GardenId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Gardens_GardenId",
                table: "Users",
                column: "GardenId",
                principalTable: "Gardens",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
