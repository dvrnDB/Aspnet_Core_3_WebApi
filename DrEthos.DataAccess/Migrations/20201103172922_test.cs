using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrEthos.DataAccess.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DrEthos");

            migrationBuilder.CreateTable(
                name: "Kisi",
                schema: "DrEthos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    State = table.Column<byte>(nullable: false),
                    OlusturmaZamani = table.Column<DateTime>(nullable: false),
                    DuzenlenmeZamani = table.Column<DateTime>(nullable: false),
                    OlusturanKullanici = table.Column<Guid>(nullable: false),
                    DuzenleyenKullanici = table.Column<string>(nullable: true),
                    Adi = table.Column<string>(nullable: false),
                    Soyadi = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "DrEthos",
                table: "Kisi",
                columns: new[] { "Id", "Adi", "DogumTarihi", "DuzenlenmeZamani", "DuzenleyenKullanici", "OlusturanKullanici", "OlusturmaZamani", "Soyadi", "State", "Telefon" },
                values: new object[] { new Guid("8a7d2a43-43d0-4985-8ec6-3c1f738172dc"), "Adem", new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(1090), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 11, 3, 20, 29, 22, 12, DateTimeKind.Local).AddTicks(587), "Bayar", (byte)0, "5398782874" });

            migrationBuilder.InsertData(
                schema: "DrEthos",
                table: "Kisi",
                columns: new[] { "Id", "Adi", "DogumTarihi", "DuzenlenmeZamani", "DuzenleyenKullanici", "OlusturanKullanici", "OlusturmaZamani", "Soyadi", "State", "Telefon" },
                values: new object[] { new Guid("d460eb40-45bb-423a-b5df-bce78e272544"), "Mehmet", new DateTime(1990, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(3209), null, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(3203), "Bayar", (byte)0, "5398782874" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisi",
                schema: "DrEthos");
        }
    }
}
