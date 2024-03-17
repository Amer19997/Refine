using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class T : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsrTable3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsrTable3Supply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable3Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable3Balance = table.Column<int>(type: "int", nullable: true),
                    AsrTable3Installments = table.Column<int>(type: "int", nullable: true),
                    AsrTable3Receipts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsrTable3", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsrTable3");
        }
    }
}
