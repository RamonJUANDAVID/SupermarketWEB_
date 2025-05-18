using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketWEB.Migrations
{
    /// <inheritdoc />
    public partial class PayMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayModeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PayModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayModes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PayModeId",
                table: "Products",
                column: "PayModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PayModes_PayModeId",
                table: "Products",
                column: "PayModeId",
                principalTable: "PayModes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PayModes_PayModeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "PayModes");

            migrationBuilder.DropIndex(
                name: "IX_Products_PayModeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PayModeId",
                table: "Products");
        }
    }
}
