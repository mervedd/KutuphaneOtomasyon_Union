using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciID",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciID",
                table: "Kitaplar",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciID",
                table: "Kitaplar",
                column: "KullaniciID",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciID",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KullaniciID",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "KullaniciID",
                table: "Kitaplar");
        }
    }
}
