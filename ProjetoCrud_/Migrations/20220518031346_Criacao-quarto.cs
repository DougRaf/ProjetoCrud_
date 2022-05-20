using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCrud_.Migrations
{
    public partial class Criacaoquarto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvaliacaoUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Avaliacao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AoperadoraId = table.Column<int>(type: "int", nullable: false),
                    OuserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacaoUser_Operadoras_AoperadoraId",
                        column: x => x.AoperadoraId,
                        principalTable: "Operadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvaliacaoUser_Usuario_OuserId",
                        column: x => x.OuserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoUser_AoperadoraId",
                table: "AvaliacaoUser",
                column: "AoperadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoUser_OuserId",
                table: "AvaliacaoUser",
                column: "OuserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacaoUser");
        }
    }
}
