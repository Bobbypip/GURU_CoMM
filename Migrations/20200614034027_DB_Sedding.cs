using Microsoft.EntityFrameworkCore.Migrations;

namespace GURU_CoMM.Migrations
{
    public partial class DB_Sedding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Luffy" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Ronny" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Senpai" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
