using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e3be2cd-3ee3-403d-b98e-6a5deccaa7a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b430d73-8154-4978-9817-f6c7a3b85400");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b03f6c4-e705-4ee3-a03e-be920a54e821", "b679129f-3f4d-4fdc-870d-f37971a41629", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76978ab8-a09c-42ae-a9b0-c96b9d041c73", "d0acffaa-ee93-4ad8-829e-fdee6b302c68", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3e3be2cd-3ee3-403d-b98e-6a5deccaa7a2", "a0998c1c-05d5-4528-9309-5694eff4849b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b430d73-8154-4978-9817-f6c7a3b85400", "613febc5-b6ae-405d-8fee-588c01d9a905", "Administrator", "ADMINISTRATOR" });
        }
    }
}
