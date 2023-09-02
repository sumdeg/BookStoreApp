using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba89d199-3570-4cff-bb2a-f5a5a8d91b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da200222-18db-49b4-9b21-e520c2e3e0c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4206cb-f47f-4b1b-8f47-2fab987a3e49");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f3fecc9-9ddd-42bc-9198-75efc278994e", "82d52c7d-3dd3-441f-8869-47cb10b711f0", "Editor", "EDITOR" },
                    { "7a17ef2e-38d5-4a9c-ac74-141380c69e57", "425afa5b-83af-4af0-9696-a439c473e2ca", "User", "USER" },
                    { "85338d4a-2692-4fcc-8336-57a7ce0722a2", "a42684af-6e57-4cd0-9939-f0786603b3e0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Management Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f3fecc9-9ddd-42bc-9198-75efc278994e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a17ef2e-38d5-4a9c-ac74-141380c69e57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85338d4a-2692-4fcc-8336-57a7ce0722a2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba89d199-3570-4cff-bb2a-f5a5a8d91b4b", "199c18fe-b360-4440-b0f5-fa19344c1516", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da200222-18db-49b4-9b21-e520c2e3e0c6", "2bff5835-c75d-43b7-bfeb-5b68013371d8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff4206cb-f47f-4b1b-8f47-2fab987a3e49", "b0121f37-e1e4-4a51-b3d0-867dcfe04ab8", "User", "USER" });
        }
    }
}
