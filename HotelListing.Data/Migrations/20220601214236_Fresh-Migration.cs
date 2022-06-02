using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Data.Migrations
{
    public partial class FreshMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c968420-c427-4479-8ee7-0c8f0d1594b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "625794fc-c957-453f-99e0-509cc262dafa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ce9ab43-367a-4476-a0da-0e1595c6baf8", "a14d6f77-ee4d-4e75-94b2-49dcc017f9a9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "241c2293-d262-4b27-b6bb-e9d337bc917d", "72d81b16-3496-44c6-a7c4-34ff1746e177", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce9ab43-367a-4476-a0da-0e1595c6baf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "241c2293-d262-4b27-b6bb-e9d337bc917d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c968420-c427-4479-8ee7-0c8f0d1594b0", "398cfebf-9488-434f-8b54-9bf25f2de142", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "625794fc-c957-453f-99e0-509cc262dafa", "c04c6e78-9ddb-4a48-b0f7-000424ae561b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
