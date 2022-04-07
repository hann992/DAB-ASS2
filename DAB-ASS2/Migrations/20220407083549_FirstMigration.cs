using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_ASS2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    booking_from = table.Column<DateTime>(type: "datetime2", nullable: false),
                    booking_to = table.Column<DateTime>(type: "datetime2", nullable: false),
                    society_Id = table.Column<int>(type: "int", nullable: false),
                    room_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Chairmen",
                columns: table => new
                {
                    chairmanid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chairman_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chairman_CPR = table.Column<long>(type: "bigint", nullable: false),
                    chairman_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairmen", x => x.chairmanid);
                });

            migrationBuilder.CreateTable(
                name: "LocationProperty",
                columns: table => new
                {
                    locationproperties_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_property_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationProperty", x => x.locationproperties_ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    location_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location_zipcode = table.Column<int>(type: "int", nullable: false),
                    location_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.location_ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomProperty",
                columns: table => new
                {
                    roomproperties_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_property_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomProperty", x => x.roomproperties_ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_capacity = table.Column<int>(type: "int", nullable: false),
                    location_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_ID);
                });

            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    society_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    society_CVR = table.Column<long>(type: "bigint", nullable: false),
                    society_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    society_activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    society_member_count = table.Column<int>(type: "int", nullable: false),
                    chairmanid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.society_ID);
                });

            migrationBuilder.CreateTable(
                name: "LocationLocationProperty",
                columns: table => new
                {
                    Locationslocation_ID = table.Column<int>(type: "int", nullable: false),
                    locationproperties_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationLocationProperty", x => new { x.Locationslocation_ID, x.locationproperties_ID });
                    table.ForeignKey(
                        name: "FK_LocationLocationProperty_LocationProperty_locationproperties_ID",
                        column: x => x.locationproperties_ID,
                        principalTable: "LocationProperty",
                        principalColumn: "locationproperties_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationLocationProperty_Locations_Locationslocation_ID",
                        column: x => x.Locationslocation_ID,
                        principalTable: "Locations",
                        principalColumn: "location_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomRoomProperty",
                columns: table => new
                {
                    Roomsroom_ID = table.Column<int>(type: "int", nullable: false),
                    roomproperties_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRoomProperty", x => new { x.Roomsroom_ID, x.roomproperties_ID });
                    table.ForeignKey(
                        name: "FK_RoomRoomProperty_RoomProperty_roomproperties_ID",
                        column: x => x.roomproperties_ID,
                        principalTable: "RoomProperty",
                        principalColumn: "roomproperties_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomRoomProperty_Rooms_Roomsroom_ID",
                        column: x => x.Roomsroom_ID,
                        principalTable: "Rooms",
                        principalColumn: "room_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationLocationProperty_locationproperties_ID",
                table: "LocationLocationProperty",
                column: "locationproperties_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRoomProperty_roomproperties_ID",
                table: "RoomRoomProperty",
                column: "roomproperties_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Chairmen");

            migrationBuilder.DropTable(
                name: "LocationLocationProperty");

            migrationBuilder.DropTable(
                name: "RoomRoomProperty");

            migrationBuilder.DropTable(
                name: "Societies");

            migrationBuilder.DropTable(
                name: "LocationProperty");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "RoomProperty");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
