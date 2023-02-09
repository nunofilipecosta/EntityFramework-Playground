﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostaSoftware.EFCorePlayground.SamuraiApp.Data.Migrations;

public partial class ADDOneToOne : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Horses",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                SamuraiId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Horses", x => x.Id);
                table.ForeignKey(
                    name: "FK_Horses_Samurais_SamuraiId",
                    column: x => x.SamuraiId,
                    principalTable: "Samurais",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Horses_SamuraiId",
            table: "Horses",
            column: "SamuraiId",
            unique: true);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Horses");
    }
}
