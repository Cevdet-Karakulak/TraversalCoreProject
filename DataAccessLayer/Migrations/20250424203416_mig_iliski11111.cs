using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_iliski11111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides1_Guide1GuideID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_Guide1GuideID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Guide1GuideID",
                table: "Destinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Guide1GuideID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_Guide1GuideID",
                table: "Destinations",
                column: "Guide1GuideID");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides1_Guide1GuideID",
                table: "Destinations",
                column: "Guide1GuideID",
                principalTable: "Guides1",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
