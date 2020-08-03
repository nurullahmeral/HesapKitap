using Microsoft.EntityFrameworkCore.Migrations;

namespace hesapkitap.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DegerKisitlas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    DegerAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegerKisitlas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiderEkles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    UrunAdı = table.Column<string>(nullable: true),
                    UrunKategorisi = table.Column<string>(nullable: true),
                    AitOlduguDonem = table.Column<string>(nullable: true),
                    Tutar = table.Column<string>(nullable: true),
                    OdemeKontrol = table.Column<string>(nullable: true),
                    OdemeTuru = table.Column<string>(nullable: true),
                    VadeTarihi = table.Column<string>(nullable: true),
                    GiderId = table.Column<int>(nullable: false),
                    GiderKategoriId = table.Column<int>(nullable: false),
                    OnKasaKontrol = table.Column<int>(nullable: false),
                    OnKasaTutar = table.Column<int>(nullable: false),
                    OdemeTuruId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiderEkles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiderKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    GiderKategoriler = table.Column<string>(nullable: true),
                    GiderKategoriId = table.Column<int>(nullable: false),
                    GiderEkleId = table.Column<int>(nullable: false),
                    UrunKategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiderKategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GunSonuKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    GunSonuKategoriId = table.Column<int>(nullable: false),
                    GunSonuKategoriName = table.Column<string>(nullable: true),
                    GunSonuTutarId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunSonuKategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GunSonuTutars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    Tutar = table.Column<double>(nullable: false),
                    Tarih = table.Column<string>(nullable: true),
                    GunsonuTutarId = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    result = table.Column<double>(nullable: false),
                    NameGunSonu = table.Column<string>(nullable: true),
                    GunSonuKategoriId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: false),
                    OnKasaKontrol = table.Column<int>(nullable: false),
                    OnKasaTutar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunSonuTutars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    GunsonuId = table.Column<int>(nullable: false),
                    NameGunSonu = table.Column<string>(nullable: true),
                    YoneticiYetkisiKontrol = table.Column<int>(nullable: false),
                    GunSonuKategoriId = table.Column<int>(nullable: false),
                    GunSonuTutarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarihKontrols",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    TarihString = table.Column<string>(nullable: true),
                    TarihGun = table.Column<int>(nullable: false),
                    TarihAy = table.Column<int>(nullable: false),
                    TarihYıl = table.Column<int>(nullable: false),
                    GiderEkleId = table.Column<int>(nullable: false),
                    GiderKategoriId = table.Column<int>(nullable: false),
                    GunSonuKategoriId = table.Column<int>(nullable: false),
                    GunSonuTutarId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: false),
                    TransferEkleId = table.Column<int>(nullable: false),
                    TransferKalemiId = table.Column<int>(nullable: false),
                    UrunKategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarihKontrols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferEkles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    TransferTarihi = table.Column<string>(nullable: true),
                    TransferNereden = table.Column<string>(nullable: true),
                    TransferNereye = table.Column<string>(nullable: true),
                    TransferTutari = table.Column<double>(nullable: false),
                    TransferAciklama = table.Column<string>(nullable: true),
                    TransferId = table.Column<int>(nullable: false),
                    TransferKalemiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferEkles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferKalemis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    TransferId = table.Column<int>(nullable: false),
                    Adı = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferKalemis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    UrunKategoriName = table.Column<string>(nullable: true),
                    GiderEkleId = table.Column<int>(nullable: false),
                    GiderKategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunKategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeGunSonuKategori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    GunSonuId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: true),
                    GunSonuKategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeGunSonuKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeGunSonuKategori_GunSonuKategoris_GunSonuKategoriId",
                        column: x => x.GunSonuKategoriId,
                        principalTable: "GunSonuKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeGunSonuKategori_Homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomeGunSonuTutar",
                columns: table => new
                {
                    GunSonuId = table.Column<int>(nullable: false),
                    GunSonuTutarId = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeGunSonuTutar", x => new { x.GunSonuId, x.GunSonuTutarId });
                    table.ForeignKey(
                        name: "FK_HomeGunSonuTutar_GunSonuTutars_GunSonuTutarId",
                        column: x => x.GunSonuTutarId,
                        principalTable: "GunSonuTutars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeGunSonuTutar_Homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferEkleKalem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    Tutar = table.Column<int>(nullable: false),
                    TransferEkleId = table.Column<int>(nullable: true),
                    Adı = table.Column<string>(nullable: true),
                    TransferKalemiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferEkleKalem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferEkleKalem_TransferEkles_TransferEkleId",
                        column: x => x.TransferEkleId,
                        principalTable: "TransferEkles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferEkleKalem_TransferKalemis_TransferKalemiId",
                        column: x => x.TransferKalemiId,
                        principalTable: "TransferKalemis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeGunSonuKategori_GunSonuKategoriId",
                table: "HomeGunSonuKategori",
                column: "GunSonuKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeGunSonuKategori_HomeId",
                table: "HomeGunSonuKategori",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeGunSonuTutar_GunSonuTutarId",
                table: "HomeGunSonuTutar",
                column: "GunSonuTutarId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeGunSonuTutar_HomeId",
                table: "HomeGunSonuTutar",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferEkleKalem_TransferEkleId",
                table: "TransferEkleKalem",
                column: "TransferEkleId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferEkleKalem_TransferKalemiId",
                table: "TransferEkleKalem",
                column: "TransferKalemiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DegerKisitlas");

            migrationBuilder.DropTable(
                name: "GiderEkles");

            migrationBuilder.DropTable(
                name: "GiderKategoris");

            migrationBuilder.DropTable(
                name: "HomeGunSonuKategori");

            migrationBuilder.DropTable(
                name: "HomeGunSonuTutar");

            migrationBuilder.DropTable(
                name: "TarihKontrols");

            migrationBuilder.DropTable(
                name: "TransferEkleKalem");

            migrationBuilder.DropTable(
                name: "UrunKategoris");

            migrationBuilder.DropTable(
                name: "GunSonuKategoris");

            migrationBuilder.DropTable(
                name: "GunSonuTutars");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "TransferEkles");

            migrationBuilder.DropTable(
                name: "TransferKalemis");
        }
    }
}
