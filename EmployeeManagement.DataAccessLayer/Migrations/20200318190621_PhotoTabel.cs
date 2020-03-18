using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.DataAccessLayer.Migrations
{
    public partial class PhotoTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BankAccountNumber", "Department", "Email", "Name", "PhotoPath" },
                values: new object[] { 3, "BE12 1234 1234 5555", 1, "Ahmed@test.com", "Ahmed", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
