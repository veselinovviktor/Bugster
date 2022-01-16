using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugster.Data.Migrations
{
    public partial class AddingDocumentsAndComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Boards_BoardId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Users_UserId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoards_Boards_BoardId",
                table: "UserBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoards_Users_UserId",
                table: "UserBoards");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_BoardId",
                table: "Documents",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Boards_BoardId",
                table: "Issues",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Users_UserId",
                table: "Issues",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoards_Boards_BoardId",
                table: "UserBoards",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoards_Users_UserId",
                table: "UserBoards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Boards_BoardId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Users_UserId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoards_Boards_BoardId",
                table: "UserBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoards_Users_UserId",
                table: "UserBoards");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Issues");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Boards_BoardId",
                table: "Issues",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Users_UserId",
                table: "Issues",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoards_Boards_BoardId",
                table: "UserBoards",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoards_Users_UserId",
                table: "UserBoards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
