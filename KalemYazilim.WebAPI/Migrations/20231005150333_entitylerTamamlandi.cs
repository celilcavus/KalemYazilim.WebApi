using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalemYazilim.WebAPI.Migrations
{
    public partial class entitylerTamamlandi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Malzeme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrunMarkasi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SonKullanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malzeme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    VKN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SatisFaturasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BelgeNo = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    BelgeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisFaturasi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatisFaturasi_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisFaturaSatiri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatirNo = table.Column<int>(type: "int", nullable: false),
                    SatisFaturasiId = table.Column<int>(type: "int", nullable: false),
                    Malzeme = table.Column<int>(type: "int", nullable: false),
                    Birim = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisFaturaSatiri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatisFaturaSatiri_SatisFaturasi_SatisFaturasiId",
                        column: x => x.SatisFaturasiId,
                        principalTable: "SatisFaturasi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SatisFaturaSatiri_SatisFaturasiId",
                table: "SatisFaturaSatiri",
                column: "SatisFaturasiId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisFaturasi_MusteriId",
                table: "SatisFaturasi",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Malzeme");

            migrationBuilder.DropTable(
                name: "SatisFaturaSatiri");

            migrationBuilder.DropTable(
                name: "SatisFaturasi");

            migrationBuilder.DropTable(
                name: "Musteris");
        }
    }
}
