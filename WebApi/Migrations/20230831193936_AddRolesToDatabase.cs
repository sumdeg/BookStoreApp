using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "658877ee-e1ca-489b-9990-a29b077a0f5f", "b7ab56fa-e703-4bd2-b0ee-52869b3b8a60", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "881d28f9-683f-433e-9728-5f921dc02c00", "6780717c-c653-44d6-b881-db2acd49db14", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbbe01de-41ff-4138-b0c6-90ff1377e7e5", "0418a4b7-5dae-4f07-891e-543f4658d059", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658877ee-e1ca-489b-9990-a29b077a0f5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "881d28f9-683f-433e-9728-5f921dc02c00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbbe01de-41ff-4138-b0c6-90ff1377e7e5");
        }
    }
}
