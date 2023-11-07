using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Migrations
{
    /// <inheritdoc />
    public partial class M04AddCurriculosTableAlterada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curriculo_Usuario_UsuarioID",
                table: "Curriculo");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Curriculo",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Curriculo",
                newName: "Objetive");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Curriculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Curriculo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Curriculo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estate",
                table: "Curriculo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Curriculo_Usuario_UsuarioID",
                table: "Curriculo",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curriculo_Usuario_UsuarioID",
                table: "Curriculo");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Curriculo");

            migrationBuilder.DropColumn(
                name: "Estate",
                table: "Curriculo");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Curriculo",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Objetive",
                table: "Curriculo",
                newName: "Email");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioID",
                table: "Curriculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Curriculo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Curriculo_Usuario_UsuarioID",
                table: "Curriculo",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
