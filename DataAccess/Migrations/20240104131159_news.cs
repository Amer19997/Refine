using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class news : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Receipts",
                table: "AsrTable1",
                newName: "Table1Receipts");

            migrationBuilder.RenameColumn(
                name: "Production",
                table: "AsrTable1",
                newName: "Table1Production");

            migrationBuilder.RenameColumn(
                name: "Distillation",
                table: "AsrTable1",
                newName: "Table1Distillation");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "AsrTable1",
                newName: "Table1Balance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Table1Receipts",
                table: "AsrTable1",
                newName: "Receipts");

            migrationBuilder.RenameColumn(
                name: "Table1Production",
                table: "AsrTable1",
                newName: "Production");

            migrationBuilder.RenameColumn(
                name: "Table1Distillation",
                table: "AsrTable1",
                newName: "Distillation");

            migrationBuilder.RenameColumn(
                name: "Table1Balance",
                table: "AsrTable1",
                newName: "Balance");
        }
    }
}
