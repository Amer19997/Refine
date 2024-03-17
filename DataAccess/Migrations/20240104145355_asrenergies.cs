using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class asrenergies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsrTable5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsrTable5Energies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable5Off = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable5OperationPower = table.Column<int>(type: "int", nullable: true),
                    AsrTable5Reasonforturningoff = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsrTable5", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsrTable5");
        }
    }
}
