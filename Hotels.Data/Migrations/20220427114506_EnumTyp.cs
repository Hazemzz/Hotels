using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotels.Data.Migrations
{
    public partial class EnumTyp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HotelReservation",
                newName: "pk_HotelReservation");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "HotelReservation",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentStatus",
                table: "HotelReservation",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pk_HotelReservation",
                table: "HotelReservation",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "HotelReservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "HotelReservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
