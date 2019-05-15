using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkMigrationsSample.Persistence.Migrations
{
    public partial class BreakingChangeCustomerFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"/* BREAKING CHANGE */
UPDATE Customer SET Name = FirstName + ' ' + LastName;"
                );

            migrationBuilder.DropColumn(
                name: "FistName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "FullName");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "UserFirstName1 UserLastName1");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "UserFirstName2 UserLastName2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FistName",
                table: "Customers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FistName", "LastName" },
                values: new object[] { "UserFirstName1", "UserLastName1" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FistName", "LastName" },
                values: new object[] { "UserFirstName2", "UserLastName2" });
        }
    }
}
