using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    loanID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    expires = table.Column<DateTime>(type: "TEXT", nullable: false),
                    personID = table.Column<int>(type: "INTEGER", nullable: false),
                    concept = table.Column<string>(type: "TEXT", nullable: true),
                    amount = table.Column<float>(type: "REAL", nullable: false),
                    balance = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.loanID);
                });

            migrationBuilder.CreateTable(
                name: "Ocupations",
                columns: table => new
                {
                    OcupationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Salary = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupations", x => x.OcupationId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    personID = table.Column<int>(type: "INTEGER", nullable: false),
                    concept = table.Column<string>(type: "TEXT", nullable: true),
                    amount = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.paymentID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    personID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    phoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    cellphoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    balance = table.Column<float>(type: "REAL", nullable: false),
                    direction = table.Column<string>(type: "TEXT", nullable: true),
                    dateBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    occupationID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.personID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentsDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentID = table.Column<int>(type: "INTEGER", nullable: false),
                    LoanID = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountPaid = table.Column<float>(type: "REAL", nullable: false),
                    PaymentspaymentID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentsDetail_Payments_PaymentspaymentID",
                        column: x => x.PaymentspaymentID,
                        principalTable: "Payments",
                        principalColumn: "paymentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsDetail_PaymentspaymentID",
                table: "PaymentsDetail",
                column: "PaymentspaymentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Ocupations");

            migrationBuilder.DropTable(
                name: "PaymentsDetail");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
