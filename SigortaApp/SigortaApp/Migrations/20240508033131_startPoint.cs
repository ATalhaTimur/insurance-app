using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SigortaApp.Migrations
{
    /// <inheritdoc />
    public partial class startPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    PolicyPrice = table.Column<int>(type: "int", nullable: false),
                    PolicyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coverage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    Ownership_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ownership_end_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    TransactionPrice = table.Column<float>(type: "real", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "Id", "Coverage", "Created_at", "End_Date", "PolicyPrice", "PolicyType", "Start_Date", "UsersId" },
                values: new object[,]
                {
                    { 1, "Full", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1012), new DateTime(2025, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1004), 1000, "Health", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(994), 1 },
                    { 2, "Full", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1014), 6000, "Car", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1014), 1 },
                    { 3, "Full", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1017), new DateTime(2025, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1017), 2000, "House", new DateTime(2024, 5, 8, 6, 31, 31, 350, DateTimeKind.Local).AddTicks(1016), 2 }
                });

            migrationBuilder.InsertData(
                table: "PolicyUser",
                columns: new[] { "Id", "Ownership_end_date", "Ownership_start_date", "PolicyId", "UsersId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, new DateTime(2025, 6, 14, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, new DateTime(2024, 12, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "PolicyId", "TransactionPrice", "TransactionType", "UsersId", "timestamp" },
                values: new object[,]
                {
                    { 1, 2, 500f, "Premium Payment", 1, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 300f, "Policy Renewal", 1, new DateTime(2024, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 700f, "Claim Reimbursement", 2, new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created_at", "Email", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "SecurePassword123!", "123-456-7890", "JohnDoe" },
                    { 2, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "AnotherSecure123!", "123-456-7891", "JaneSmith" },
                    { 3, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.johnson@example.com", "PasswordSecure456!", "123-456-7892", "AliceJohnson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "PolicyUser");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
