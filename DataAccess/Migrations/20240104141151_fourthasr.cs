using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fourthasr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsrTable4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsrTable4ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable4Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable4Balance = table.Column<int>(type: "int", nullable: true),
                    AsrTable4Installments = table.Column<int>(type: "int", nullable: true),
                    AsrTable4Receipts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsrTable4", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsrTable4");
        }
    }
}
