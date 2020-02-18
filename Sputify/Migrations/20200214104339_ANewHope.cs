using Microsoft.EntityFrameworkCore.Migrations;

namespace Sputify.Migrations
{
    public partial class ANewHope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Collections_CollectionID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_CollectionID",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CollectionID",
                table: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "SongID",
                table: "Collections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collections_SongID",
                table: "Collections",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Songs_SongID",
                table: "Collections",
                column: "SongID",
                principalTable: "Songs",
                principalColumn: "SongID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Songs_SongID",
                table: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Collections_SongID",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SongID",
                table: "Collections");

            migrationBuilder.AddColumn<int>(
                name: "CollectionID",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_CollectionID",
                table: "Songs",
                column: "CollectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Collections_CollectionID",
                table: "Songs",
                column: "CollectionID",
                principalTable: "Collections",
                principalColumn: "CollectionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
