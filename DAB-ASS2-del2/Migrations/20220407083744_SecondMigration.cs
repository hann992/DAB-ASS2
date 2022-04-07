using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_ASS2.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KeyResponsible_Id",
                table: "Societies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "keyResponsibles",
                columns: table => new
                {
                    key_responsible_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key_responsible_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    key_responsible_CPR = table.Column<long>(type: "bigint", nullable: false),
                    key_responsible_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    key_responsible_phone = table.Column<long>(type: "bigint", nullable: false),
                    key_responsible_photo_ID_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyResponsibles", x => x.key_responsible_ID);
                });

            migrationBuilder.CreateTable(
                name: "LocationAccesses",
                columns: table => new
                {
                    locationcodes_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationcode = table.Column<int>(type: "int", nullable: true),
                    location_key_pickup_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    locationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAccesses", x => x.locationcodes_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keyResponsibles");

            migrationBuilder.DropTable(
                name: "LocationAccesses");

            migrationBuilder.DropColumn(
                name: "KeyResponsible_Id",
                table: "Societies");
        }
    }
}
