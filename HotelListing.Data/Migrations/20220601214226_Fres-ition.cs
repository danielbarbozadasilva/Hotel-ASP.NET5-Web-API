using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Data.Migrations
{
    public partial class Fresition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bcbab4e-8e98-40d0-b0f0-d559f5766305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccabb997-f228-461b-8c66-863b7f1d7b38");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c968420-c427-4479-8ee7-0c8f0d1594b0", "398cfebf-9488-434f-8b54-9bf25f2de142", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "625794fc-c957-453f-99e0-509cc262dafa", "c04c6e78-9ddb-4a48-b0f7-000424ae561b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7bcbab4e-8e98-40d0-b0f0-d559f5766305", "d66152d4-e5c4-44ec-b790-7e7128a286a8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccabb997-f228-461b-8c66-863b7f1d7b38", "9f8aa70c-b8fc-4f72-8b72-67b3a387d12a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
