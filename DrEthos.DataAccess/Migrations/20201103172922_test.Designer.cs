﻿// <auto-generated />
using System;
using DrEthos.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrEthos.DataAccess.Migrations
{
    [DbContext(typeof(EFDatabaseContext))]
    [Migration("20201103172922_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrEthos.Entities.Kisiler.Kisi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DuzenlenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<string>("DuzenleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OlusturanKullanici")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OlusturmaZamani")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kisi","DrEthos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a7d2a43-43d0-4985-8ec6-3c1f738172dc"),
                            Adi = "Adem",
                            DogumTarihi = new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DuzenlenmeZamani = new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(1090),
                            OlusturanKullanici = new Guid("00000000-0000-0000-0000-000000000000"),
                            OlusturmaZamani = new DateTime(2020, 11, 3, 20, 29, 22, 12, DateTimeKind.Local).AddTicks(587),
                            Soyadi = "Bayar",
                            State = (byte)0,
                            Telefon = "5398782874"
                        },
                        new
                        {
                            Id = new Guid("d460eb40-45bb-423a-b5df-bce78e272544"),
                            Adi = "Mehmet",
                            DogumTarihi = new DateTime(1990, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DuzenlenmeZamani = new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(3209),
                            OlusturanKullanici = new Guid("00000000-0000-0000-0000-000000000000"),
                            OlusturmaZamani = new DateTime(2020, 11, 3, 20, 29, 22, 16, DateTimeKind.Local).AddTicks(3203),
                            Soyadi = "Bayar",
                            State = (byte)0,
                            Telefon = "5398782874"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
