using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Anrpc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsrTable3");

            migrationBuilder.DropTable(
                name: "AsrTable5");

            migrationBuilder.CreateTable(
                name: "AnrpcTable1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<int>(type: "int", nullable: true),
                    Receipts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnrpcTable1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnrpcTable2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnrpcTable2Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnrpcTable2Balance = table.Column<int>(type: "int", nullable: true),
                    AnrpcTable2Installments = table.Column<int>(type: "int", nullable: true),
                    AnrpcTable2Receipts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnrpcTable2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnrpcTable3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnrpcTable3Energies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnrpcTable3Off = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnrpcTable3OperationPower = table.Column<int>(type: "int", nullable: true),
                    AnrpcTable3Reasonforturningoff = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnrpcTable3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnrpcTable4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnrpcTable4Mixing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnrpcTable4Gasoline80 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnrpcTable4Gasoline92 = table.Column<int>(type: "int", nullable: true),
                    AnrpcTable4Gasoline95 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnrpcTable4", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnrpcTable1");

            migrationBuilder.DropTable(
                name: "AnrpcTable2");

            migrationBuilder.DropTable(
                name: "AnrpcTable3");

            migrationBuilder.DropTable(
                name: "AnrpcTable4");

            migrationBuilder.CreateTable(
                name: "AsrTable3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsrTable3Balance = table.Column<int>(type: "int", nullable: true),
                    AsrTable3Installments = table.Column<int>(type: "int", nullable: true),
                    AsrTable3Products = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsrTable3Receipts = table.Column<int>(type: "int", nullable: true),
                    AsrTable3Supply = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsrTable3", x => x.Id);
                });

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
    }
}
