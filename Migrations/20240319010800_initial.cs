﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpMVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Processador = table.Column<string>(type: "TEXT", nullable: false),
                    PlacaMae = table.Column<string>(type: "TEXT", nullable: false),
                    Memoria = table.Column<string>(type: "TEXT", nullable: false),
                    Hd = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroPatrimonio = table.Column<string>(type: "TEXT", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computador", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computador");
        }
    }
}
