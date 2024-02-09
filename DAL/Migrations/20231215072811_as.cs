using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class @as : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciID",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "Kitaplar",
                newName: "KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaplar_KullaniciID",
                table: "Kitaplar",
                newName: "IX_Kitaplar_KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KullaniciId",
                table: "Kitaplar",
                newName: "KullaniciID");

            migrationBuilder.RenameIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar",
                newName: "IX_Kitaplar_KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciID",
                table: "Kitaplar",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
