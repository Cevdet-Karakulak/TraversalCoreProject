using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_dest1_guide11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Destination1DestinationID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Guide1GuideID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Destination1DestinationID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Destinations1",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations1", x => x.DestinationID);
                    table.ForeignKey(
                        name: "FK_Destinations1_Guides_GuideID",
                        column: x => x.GuideID,
                        principalTable: "Guides",
                        principalColumn: "GuideID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guides1",
                columns: table => new
                {
                    GuideID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides1", x => x.GuideID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Destination1DestinationID",
                table: "Reservations",
                column: "Destination1DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_Guide1GuideID",
                table: "Destinations",
                column: "Guide1GuideID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Destination1DestinationID",
                table: "Comments",
                column: "Destination1DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations1_GuideID",
                table: "Destinations1",
                column: "GuideID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destinations1_Destination1DestinationID",
                table: "Comments",
                column: "Destination1DestinationID",
                principalTable: "Destinations1",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides1_Guide1GuideID",
                table: "Destinations",
                column: "Guide1GuideID",
                principalTable: "Guides1",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations1_Destination1DestinationID",
                table: "Reservations",
                column: "Destination1DestinationID",
                principalTable: "Destinations1",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destinations1_Destination1DestinationID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides1_Guide1GuideID",
                table: "Destinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations1_Destination1DestinationID",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Destinations1");

            migrationBuilder.DropTable(
                name: "Guides1");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_Destination1DestinationID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_Guide1GuideID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Destination1DestinationID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Destination1DestinationID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Guide1GuideID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Destination1DestinationID",
                table: "Comments");
        }
    }
}
