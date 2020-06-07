using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_ChooseYourOwnAdventure.Migrations
{
    public partial class GameDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameID",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameID",
                table: "Games",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_StoryboardID",
                table: "Games",
                column: "StoryboardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Games_GameID",
                table: "Games",
                column: "GameID",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Games_StoryboardID",
                table: "Games",
                column: "StoryboardID",
                principalTable: "Games",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Games_GameID",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Games_StoryboardID",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameID",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_StoryboardID",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameID",
                table: "Games");
        }
    }
}
