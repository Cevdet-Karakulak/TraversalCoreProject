using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_destination11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations1_Guides1_Guide1GuideID",
                table: "Destinations1");

            migrationBuilder.DropIndex(
                name: "IX_Destinations1_Guide1GuideID",
                table: "Destinations1");

            migrationBuilder.DropColumn(
                name: "Guide1GuideID",
                table: "Destinations1");

            migrationBuilder.DropColumn(
                name: "GuideID",
                table: "Destinations1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Guide1GuideID",
                table: "Destinations1",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuideID",
                table: "Destinations1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations1_Guide1GuideID",
                table: "Destinations1",
                column: "Guide1GuideID");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations1_Guides1_Guide1GuideID",
                table: "Destinations1",
                column: "Guide1GuideID",
                principalTable: "Guides1",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
