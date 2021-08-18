using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo.Data.Migrations
{
    public partial class AddResumeANDGameToDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlayer_Game_GameId",
                table: "GamePlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Players_PlayerId",
                table: "Resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resume",
                table: "Resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.RenameTable(
                name: "Resume",
                newName: "Resumes");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_Resume_PlayerId",
                table: "Resumes",
                newName: "IX_Resumes_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resumes",
                table: "Resumes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlayer_Games_GameId",
                table: "GamePlayer",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Players_PlayerId",
                table: "Resumes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlayer_Games_GameId",
                table: "GamePlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Players_PlayerId",
                table: "Resumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resumes",
                table: "Resumes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Resumes",
                newName: "Resume");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameIndex(
                name: "IX_Resumes_PlayerId",
                table: "Resume",
                newName: "IX_Resume_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resume",
                table: "Resume",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlayer_Game_GameId",
                table: "GamePlayer",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Players_PlayerId",
                table: "Resume",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
