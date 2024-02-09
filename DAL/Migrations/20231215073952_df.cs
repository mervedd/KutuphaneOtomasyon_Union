using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class df : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId");

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

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar");
        }
    }
}
