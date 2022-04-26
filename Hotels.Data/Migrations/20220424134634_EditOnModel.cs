using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotels.Data.Migrations
{
    public partial class EditOnModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HotelReservationRooms_HotelReservationId",
                table: "HotelReservationRooms",
                column: "HotelReservationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelReservationRooms_HotelReservation_HotelReservationId",
                table: "HotelReservationRooms",
                column: "HotelReservationId",
                principalTable: "HotelReservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelReservationRooms_HotelReservation_HotelReservationId",
                table: "HotelReservationRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelReservationRooms_HotelReservationId",
                table: "HotelReservationRooms");
        }
    }
}
