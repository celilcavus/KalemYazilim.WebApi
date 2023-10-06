﻿// <auto-generated />
using System;
using KalemYazilim.WebAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KalemYazilim.WebAPI.Migrations
{
    [DbContext(typeof(KalemDb))]
    [Migration("20231006195837_entitychanged2")]
    partial class entitychanged2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.Malzeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SonKullanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UrunMarkasi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Malzeme");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("VKN")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.SatisFaturaSatiri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Birim")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MalzemeId")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<int>("SatirNo")
                        .HasColumnType("int");

                    b.Property<int>("SatisFaturasiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SatisFaturasiId");

                    b.ToTable("SatisFaturaSatiri");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.SatisFaturasi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BelgeNo")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("BelgeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("SatisFaturasi");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.SatisFaturaSatiri", b =>
                {
                    b.HasOne("KalemYazilim.WebAPI.Model.SatisFaturasi", "SatisFaturasi")
                        .WithMany("SatisFaturaSatiri")
                        .HasForeignKey("SatisFaturasiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SatisFaturasi");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.SatisFaturasi", b =>
                {
                    b.HasOne("KalemYazilim.WebAPI.Model.Musteri", "Musteri")
                        .WithMany("SatisFaturaSatiri")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.Musteri", b =>
                {
                    b.Navigation("SatisFaturaSatiri");
                });

            modelBuilder.Entity("KalemYazilim.WebAPI.Model.SatisFaturasi", b =>
                {
                    b.Navigation("SatisFaturaSatiri");
                });
#pragma warning restore 612, 618
        }
    }
}
