﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetSavory.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat");

            migrationBuilder.DropColumn(
                name: "Enrollment",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "FlavorNumber",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "FlavorTreat",
                newName: "FlavorTreats");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_TreatId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreat_FlavorId",
                table: "FlavorTreats",
                newName: "IX_FlavorTreats_FlavorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats",
                column: "FlavorTreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Flavors_FlavorId",
                table: "FlavorTreats");

            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_Treats_TreatId",
                table: "FlavorTreats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlavorTreats",
                table: "FlavorTreats");

            migrationBuilder.RenameTable(
                name: "FlavorTreats",
                newName: "FlavorTreat");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_TreatId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_TreatId");

            migrationBuilder.RenameIndex(
                name: "IX_FlavorTreats_FlavorId",
                table: "FlavorTreat",
                newName: "IX_FlavorTreat_FlavorId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Enrollment",
                table: "Treats",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FlavorNumber",
                table: "Flavors",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlavorTreat",
                table: "FlavorTreat",
                column: "FlavorTreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Flavors_FlavorId",
                table: "FlavorTreat",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
