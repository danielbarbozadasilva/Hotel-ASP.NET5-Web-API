using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b03f6c4-e705-4ee3-a03e-be920a54e821");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76978ab8-a09c-42ae-a9b0-c96b9d041c73");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa006cac-95f2-4721-a9af-de99bac910f5", "1d83ec53-bde5-4543-8a63-ba50b2c2bfed", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e3ca976-d4a3-42c0-88c3-1dc6f9bb4711", "c67c7e82-cb7b-4320-bbbf-a359aeb602d6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e3ca976-d4a3-42c0-88c3-1dc6f9bb4711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa006cac-95f2-4721-a9af-de99bac910f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b03f6c4-e705-4ee3-a03e-be920a54e821", "b679129f-3f4d-4fdc-870d-f37971a41629", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76978ab8-a09c-42ae-a9b0-c96b9d041c73", "d0acffaa-ee93-4ad8-829e-fdee6b302c68", "Administrator", "ADMINISTRATOR" });
        }
    }
}
