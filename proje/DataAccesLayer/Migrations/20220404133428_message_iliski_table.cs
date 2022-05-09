﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class message_iliski_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "message2s",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message2s", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_message2s_Writers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_message2s_Writers_senderID",
                        column: x => x.senderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_message2s_ReceiverID",
                table: "message2s",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_message2s_senderID",
                table: "message2s",
                column: "senderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "message2s");
        }
    }
}