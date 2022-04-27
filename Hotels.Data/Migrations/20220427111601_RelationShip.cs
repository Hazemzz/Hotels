using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotels.Data.Migrations
{
    public partial class RelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelReservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BookingReferenceNumber = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CheckInDate = table.Column<DateTime>(nullable: false),
                    CheckOuDate = table.Column<DateTime>(nullable: false),
                    PaymentStatus = table.Column<string>(nullable: true),
                    ReservationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelReservationRooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelReservationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    IsRefundable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReservationRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelReservationRooms_HotelReservation_HotelReservationId",
                        column: x => x.HotelReservationId,
                        principalTable: "HotelReservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationRooms_HotelReservationId",
                table: "HotelReservationRooms",
                column: "HotelReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelReservationRooms");

            migrationBuilder.DropTable(
                name: "HotelReservation");
        }
    }
}
