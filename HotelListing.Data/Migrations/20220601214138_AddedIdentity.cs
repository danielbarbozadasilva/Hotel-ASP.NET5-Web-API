using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Data.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f4a12bc-98d7-42e1-9d43-7afef22a8d63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8ee7ad9-dc9e-4f49-8ffa-0c9342def8b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a76582fa-18a6-4269-adf2-0ba205ec70c5", "60db6b43-de58-411a-9e14-f501f8a5e6b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f66b64b-3839-48a3-9a9e-c6afc677388e", "fa0cbce9-bd00-4fef-8da5-7a7efe4077a3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7f4a12bc-98d7-42e1-9d43-7afef22a8d63", "104ff6e7-0a92-4171-bf7c-4d0d51acab25", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8ee7ad9-dc9e-4f49-8ffa-0c9342def8b1", "001ece43-4f03-4ffa-bb4a-0b498addf45e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
