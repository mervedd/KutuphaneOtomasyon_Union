using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class w : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
