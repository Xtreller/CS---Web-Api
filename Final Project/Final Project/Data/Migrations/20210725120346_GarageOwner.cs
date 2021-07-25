using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Data.Migrations
{
    public partial class GarageOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Done_Jobs",
                table: "Garages",
                newName: "Done_jobs");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Garages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Owner_id",
                table: "Garages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Garages_OwnerId",
                table: "Garages",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garages_AspNetUsers_OwnerId",
                table: "Garages",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garages_AspNetUsers_OwnerId",
                table: "Garages");

            migrationBuilder.DropIndex(
                name: "IX_Garages_OwnerId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "Owner_id",
                table: "Garages");

            migrationBuilder.RenameColumn(
                name: "Done_jobs",
                table: "Garages",
                newName: "Done_Jobs");
        }
    }
}
