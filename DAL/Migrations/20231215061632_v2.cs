using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "Kitaplar",
                newName: "YazarAdi");

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "YayineviId",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BarkodNo",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KitapAdi",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RafNo",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StokSayisi",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Turu",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Yayinevi",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "sayfasayisi",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar",
                column: "YayineviId",
                principalTable: "Yayinevleri",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarId",
                table: "Kitaplar",
                column: "YazarId",
                principalTable: "Yazarlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "BarkodNo",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "KitapAdi",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "RafNo",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "StokSayisi",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Turu",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Yayinevi",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "sayfasayisi",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "YazarAdi",
                table: "Kitaplar",
                newName: "Adi");

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "YayineviId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriId",
                table: "Kitaplar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yayinevleri_YayineviId",
                table: "Kitaplar",
                column: "YayineviId",
                principalTable: "Yayinevleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarId",
                table: "Kitaplar",
                column: "YazarId",
                principalTable: "Yazarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
