using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMigrationsSample.Persistence.Migrations
{
    public partial class AddSeedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FistName", "LastName" },
                values: new object[] { 1, "UserFirstName1", "UserLastName1" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FistName", "LastName" },
                values: new object[] { 2, "UserFirstName2", "UserLastName2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
