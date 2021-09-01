﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ConfigureForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_ClientId",
                table: "Interactions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_EmpId",
                table: "Interactions",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Clients_ClientId",
                table: "Interactions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Employees_EmpId",
                table: "Interactions",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Clients_ClientId",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Employees_EmpId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_ClientId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Interactions_EmpId",
                table: "Interactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Clients",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }
    }
}
