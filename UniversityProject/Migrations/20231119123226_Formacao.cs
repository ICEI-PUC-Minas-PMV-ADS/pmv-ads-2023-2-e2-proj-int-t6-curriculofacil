using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Migrations
{
    /// <inheritdoc />
    public partial class Formacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formacao",
                columns: table => new
                {
                    FormacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstDeEnsino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diploma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoDeEstudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataTermino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurriculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formacao", x => x.FormacaoID);
                    table.ForeignKey(
                        name: "FK_Formacao_Curriculos_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculos",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formacao_CurriculoID",
                table: "Formacao",
                column: "CurriculoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formacao");
        }
    }
}
