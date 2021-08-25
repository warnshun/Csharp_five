using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Introduction = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EmployeeNo = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), "Microsoft Company", "Microsoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("6fb600c1-9011-4fd7-9234-881379716440"), "Google Company", "Google" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("5efc910b-2f45-43df-afae-620d40542853"), "Apple Company", "Apple" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("0f40e053-252b-4de7-ae6d-164e7fa87b85"), "Microsoft Company", "Microsoft2" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("8f2bcc74-0226-4de3-8581-d179cf039407"), "Google Company", "Google2" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("1f45d6c1-e5a0-435a-851c-418c818fa1e2"), "Apple Company", "Apple2" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("92267a79-e640-4ecd-9ad2-26e58e68558d"), "Microsoft Company", "Microsoft3" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("ab8f0e97-361f-4996-b449-2bfa8cd0c9df"), "Google Company", "Google3" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("1d7317fa-e637-46c4-a132-557a2b0829fe"), "Apple Company", "Apple3" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("5d654ea0-5434-4878-9346-c29d67882165"), "Microsoft Company", "Microsoft4" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("04b37a9a-037f-4169-9a0f-ad25cb06dfe9"), "Google Company", "Google4" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("6bd6bc9b-a502-4397-b161-e1963b28f6a1"), "Apple Company", "Apple4" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("ee61d1ce-2882-4212-ab47-a99f34681c82"), "Microsoft Company", "Microsoft5" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("50e92e5e-02b7-42bb-b9f4-5d89b42a05d1"), "Google Company", "Google5" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("0a9975cf-befd-46d1-ab1b-e985b980d123"), "Apple Company", "Apple5" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
