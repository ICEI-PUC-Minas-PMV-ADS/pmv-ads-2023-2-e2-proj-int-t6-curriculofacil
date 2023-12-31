﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Migrations
{
    /// <inheritdoc />
    public partial class MD07AlteracoesTableFormacao : Migration
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
                    CampoDeEstudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "HistoricoProfissional",
                columns: table => new
                {
                    HistoricoProfissinalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empregador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurriculoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoProfissional", x => x.HistoricoProfissinalID);
                    table.ForeignKey(
                        name: "FK_HistoricoProfissional_Curriculos_CurriculoID",
                        column: x => x.CurriculoID,
                        principalTable: "Curriculos",
                        principalColumn: "CurriculoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formacao_CurriculoID",
                table: "Formacao",
                column: "CurriculoID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_CurriculoID",
                table: "HistoricoProfissional",
                column: "CurriculoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formacao");

            migrationBuilder.DropTable(
                name: "HistoricoProfissional");
        }
    }
}
