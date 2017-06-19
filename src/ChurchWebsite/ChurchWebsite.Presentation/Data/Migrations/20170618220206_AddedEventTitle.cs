using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchWebsite.Presentation.Data.Migrations
{
    public partial class AddedEventTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventText",
                table: "EventItems",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventTitle",
                table: "EventItems",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventTitle",
                table: "EventItems");

            migrationBuilder.AlterColumn<string>(
                name: "EventText",
                table: "EventItems",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512);
        }
    }
}
