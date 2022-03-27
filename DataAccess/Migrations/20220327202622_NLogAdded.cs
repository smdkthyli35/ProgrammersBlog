using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class NLogAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Logger = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Callsite = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    Exception = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(7497) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8754), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8752), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8756) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8763), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8764) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8769), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8771) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8777), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8779) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8785), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8783), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8786) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8849), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8852) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8859), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8857), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8860) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8866), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8868) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8874), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 3, 27, 23, 26, 22, 90, DateTimeKind.Local).AddTicks(8875) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3711) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3727), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3728) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3733), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3734) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3740) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3745) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3751) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3755), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3757) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3761), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3762) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3768) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 3, 27, 23, 26, 22, 94, DateTimeKind.Local).AddTicks(3773) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(996), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1008) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1022), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1023) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1028), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1029) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1033), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1035) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1040) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1045), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1046) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1052) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1057) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1063) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1067), new DateTime(2022, 3, 27, 23, 26, 22, 97, DateTimeKind.Local).AddTicks(1069) });

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "ConcurrencyStamp",
            //    value: "97b23cbe-f244-47fe-a293-2b8165ca1fc1");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "ConcurrencyStamp",
            //    value: "52b8ff28-e200-423c-a301-c29d1ff03021");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    column: "ConcurrencyStamp",
            //    value: "2824fba2-80b5-4f57-9838-7e7cf5bd9961");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    column: "ConcurrencyStamp",
            //    value: "54763d86-e781-4673-9300-41c11c2a8226");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    column: "ConcurrencyStamp",
            //    value: "f19bd81c-0325-4227-b679-2afaa5dc4b22");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    column: "ConcurrencyStamp",
            //    value: "dce2207a-da9d-47bd-9758-118872fdc644");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    column: "ConcurrencyStamp",
            //    value: "b49e07b8-9b2a-4055-8fbe-947b28e564c3");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    column: "ConcurrencyStamp",
            //    value: "3f6a3176-2295-4d1b-a71f-ee24f636c8e0");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    column: "ConcurrencyStamp",
            //    value: "75333117-dfd4-4523-9c4d-fadcad59254d");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    column: "ConcurrencyStamp",
            //    value: "f047db84-015e-4517-8964-3994b46bb972");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    column: "ConcurrencyStamp",
            //    value: "b70ecb36-52c0-4016-a0b3-f3aad2f71a03");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    column: "ConcurrencyStamp",
            //    value: "f93cd09a-11df-46c8-8ad6-c3c07775a6c4");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    column: "ConcurrencyStamp",
            //    value: "901053f8-1774-4317-9c15-4384d3a2a54d");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    column: "ConcurrencyStamp",
            //    value: "f3519921-6999-4c6c-afad-b374fb128830");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 15,
            //    column: "ConcurrencyStamp",
            //    value: "ea75b5bb-129a-4166-8b78-76eba13a160b");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 16,
            //    column: "ConcurrencyStamp",
            //    value: "8c0e926b-fb36-42b8-8957-d17ce3cc14a9");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 17,
            //    column: "ConcurrencyStamp",
            //    value: "839fe82f-4c87-489e-b9d5-d587d9f3e414");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 18,
            //    column: "ConcurrencyStamp",
            //    value: "03b030a8-a11d-4cae-a22d-59cec56607da");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 19,
            //    column: "ConcurrencyStamp",
            //    value: "8d92638c-e5ce-4f01-8978-9a5cffcfe936");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 20,
            //    column: "ConcurrencyStamp",
            //    value: "be2923c2-4ec7-4099-9431-044bf219817f");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 21,
            //    column: "ConcurrencyStamp",
            //    value: "78a68a17-0bae-4c1d-8862-522874acbcec");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 22,
            //    column: "ConcurrencyStamp",
            //    value: "8d61e132-9a9b-4dce-a583-415a762a1772");

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "f1467c0a-be90-484d-be70-e8ebda33e8e9", "AQAAAAEAACcQAAAAEFuTPMKmLE/ybWkco7Yn/Vnfv7sHknc1J4UugaYF4O9ztfxS0FZ0tWqxm9NAaqqUSw==", "1553465f-9acf-4b39-b116-876f1cd6153e" });

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "3e95bffa-61de-4a04-a145-85915245b52b", "AQAAAAEAACcQAAAAEJcBCg5F8fpiumGvfkRjza7zg4PCfZLkokEVSG7sPOYlNgVg4P429irtk+VoiUmzhw==", "191e66dd-4c19-4966-9098-68361ce07ecb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(4372), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(4931) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6235) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6244), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6242), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6246) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6254), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6252), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6258) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6264), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6262), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6265) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6286) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6292), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6294) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6298), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6301) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6307), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6305), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6308) });

            //migrationBuilder.UpdateData(
            //    table: "Articles",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 3, 24, 18, 21, 47, 224, DateTimeKind.Local).AddTicks(6316) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2894), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2918) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2934) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2938), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2939) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2944), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2945) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2949), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2951) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2955), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2956) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2962) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2967) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2972), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2973) });

            //migrationBuilder.UpdateData(
            //    table: "Categories",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2977), new DateTime(2022, 3, 24, 18, 21, 47, 228, DateTimeKind.Local).AddTicks(2979) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1181), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1200) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1212), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1214) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1220) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1224), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1225) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1230), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1231) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1236) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1242) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1247) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1253) });

            //migrationBuilder.UpdateData(
            //    table: "Comments",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    columns: new[] { "CreatedDate", "ModifiedDate" },
            //    values: new object[] { new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 3, 24, 18, 21, 47, 231, DateTimeKind.Local).AddTicks(1258) });

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    column: "ConcurrencyStamp",
            //    value: "d7dc12cf-2c96-4dae-9877-ea799ca9f930");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    column: "ConcurrencyStamp",
            //    value: "46a43de9-226e-4166-8f8b-f8f4d54d404f");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 3,
            //    column: "ConcurrencyStamp",
            //    value: "9094cce7-051f-4fa6-a43f-0668e925eaa6");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 4,
            //    column: "ConcurrencyStamp",
            //    value: "0fa058cb-164c-48af-95eb-7ad498df944d");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 5,
            //    column: "ConcurrencyStamp",
            //    value: "db165936-f71f-41ed-9da8-b062b0929fe0");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 6,
            //    column: "ConcurrencyStamp",
            //    value: "8e9a6eed-05ed-4471-b31a-c71dc858c0e5");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 7,
            //    column: "ConcurrencyStamp",
            //    value: "f519f349-0b6e-4fad-be30-f4d0ebefd855");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 8,
            //    column: "ConcurrencyStamp",
            //    value: "8856c433-4401-4fd1-884b-46e7943869c6");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 9,
            //    column: "ConcurrencyStamp",
            //    value: "c4ba10cd-34a4-42ca-a66a-f7a855f1183f");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 10,
            //    column: "ConcurrencyStamp",
            //    value: "1ef67f52-a2a3-4972-a0a3-1b5d84433691");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 11,
            //    column: "ConcurrencyStamp",
            //    value: "fa180ed9-bef3-4f29-961d-687ef3aa49c0");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 12,
            //    column: "ConcurrencyStamp",
            //    value: "a0b44396-7165-46bf-b42d-7ab1969c4006");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 13,
            //    column: "ConcurrencyStamp",
            //    value: "e93a63cf-8fa0-4766-b2f3-c2812659950c");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 14,
            //    column: "ConcurrencyStamp",
            //    value: "5d4689f9-886a-4b51-8519-f985a4bb6004");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 15,
            //    column: "ConcurrencyStamp",
            //    value: "13ca7e37-94b1-47ea-9e62-96d50e563100");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 16,
            //    column: "ConcurrencyStamp",
            //    value: "c1c15571-dda8-4ee7-944a-69c398d034f6");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 17,
            //    column: "ConcurrencyStamp",
            //    value: "4e89e850-cc54-45e2-a473-9186783a1887");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 18,
            //    column: "ConcurrencyStamp",
            //    value: "34871acb-580f-4a7f-8f14-1c41220da1e2");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 19,
            //    column: "ConcurrencyStamp",
            //    value: "96a086bd-bed5-489f-8140-472348909e1a");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 20,
            //    column: "ConcurrencyStamp",
            //    value: "676ab4df-a847-40f6-bb2e-f06792647990");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 21,
            //    column: "ConcurrencyStamp",
            //    value: "816433d3-114c-47e9-9249-16a25f770979");

            //migrationBuilder.UpdateData(
            //    table: "Roles",
            //    keyColumn: "Id",
            //    keyValue: 22,
            //    column: "ConcurrencyStamp",
            //    value: "7f2eef05-9904-4a73-8754-c52a507a331b");

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 1,
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "df414a13-5965-4558-acf7-7135c90dfbdd", "AQAAAAEAACcQAAAAEIq7rsHheIia4AVoYntGiSjb5ADPfyyAMBUyqyVFyYbswkFt4E7F8vVWy9ANhZjipg==", "af8d7408-cb84-45c0-a433-cd85384bd092" });

            //migrationBuilder.UpdateData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 2,
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "af6a0798-ac69-49cd-9372-2b75dd157a02", "AQAAAAEAACcQAAAAEI0HIMW/9kGEp/YhAgocIQ8LD0l2mJnnTMxP/qEDfe3TKXPDikumboE3cXPs8qYO3A==", "5d773142-1249-417a-99fa-3636efad25be" });
        }
    }
}
