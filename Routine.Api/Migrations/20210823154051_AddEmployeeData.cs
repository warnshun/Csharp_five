using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Api.Migrations
{
    public partial class AddEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("5b9e8ecd-71a5-46b5-8ec4-2a7a002d9ada"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS231", "Nick", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("2e1c7b17-b912-43ed-896c-652735a00b6d"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS245", "Vince", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("eb6401ae-9113-4d6c-9d2d-e9cc6208f1c6"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MS279", "Maria", 0, "Los" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7e2ebe97-11da-4b62-b644-f2885b7f038c"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "GG231", "Nick", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7061fd5a-b7ee-45a0-8a97-566f6dfc5c2e"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GG245", "Vince", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("94981ae0-0954-446c-87a8-58abbdbe8d6f"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GG279", "Maria", 0, "Los" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("bbbf271a-e6f9-4584-a882-236e51114f6f"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "AP231", "Nick", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("86d7915c-2575-438a-ac40-47ddaafa3708"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AP245", "Vince", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("4666e3ea-d14f-4996-a036-b3737bbda486"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AP279", "Maria", 0, "Los" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2e1c7b17-b912-43ed-896c-652735a00b6d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4666e3ea-d14f-4996-a036-b3737bbda486"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5b9e8ecd-71a5-46b5-8ec4-2a7a002d9ada"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7061fd5a-b7ee-45a0-8a97-566f6dfc5c2e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7e2ebe97-11da-4b62-b644-f2885b7f038c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("86d7915c-2575-438a-ac40-47ddaafa3708"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("94981ae0-0954-446c-87a8-58abbdbe8d6f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bbbf271a-e6f9-4584-a882-236e51114f6f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eb6401ae-9113-4d6c-9d2d-e9cc6208f1c6"));
        }
    }
}
