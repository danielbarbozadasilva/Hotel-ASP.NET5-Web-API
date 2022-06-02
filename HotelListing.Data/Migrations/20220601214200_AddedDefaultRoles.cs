using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Data.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f66b64b-3839-48a3-9a9e-c6afc677388e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a76582fa-18a6-4269-adf2-0ba205ec70c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bcbab4e-8e98-40d0-b0f0-d559f5766305", "d66152d4-e5c4-44ec-b790-7e7128a286a8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccabb997-f228-461b-8c66-863b7f1d7b38", "9f8aa70c-b8fc-4f72-8b72-67b3a387d12a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "a76582fa-18a6-4269-adf2-0ba205ec70c5", "60db6b43-de58-411a-9e14-f501f8a5e6b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f66b64b-3839-48a3-9a9e-c6afc677388e", "fa0cbce9-bd00-4fef-8da5-7a7efe4077a3", "Administrator", "ADMINISTRATOR" });
        }
    }
}
