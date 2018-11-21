﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotifi.Models;

namespace Spotifi.Migrations
{
    [DbContext(typeof(SpotifiContext))]
    [Migration("20181022222435_banda_abreviacion")]
    partial class banda_abreviacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Spotifi.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BandaId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("BandaId");

                    b.ToTable("Albumes");
                });

            modelBuilder.Entity("Spotifi.Models.Banda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abreviacion");

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Bandas");

                    b.HasData(
                        new { Id = 1, Foto = "https://i.kym-cdn.com/photos/images/newsfeed/000/937/730/e9a.jpg", Nombre = "Link in Park" },
                        new { Id = 2, Foto = "https://multimedia.larepublica.pe/720x405/larepublica/imagen/2018/10/16/noticia-peli-bts-burn-stage.jpg", Nombre = "BTS" }
                    );
                });

            modelBuilder.Entity("Spotifi.Models.Album", b =>
                {
                    b.HasOne("Spotifi.Models.Banda", "Banda")
                        .WithMany("Albumes")
                        .HasForeignKey("BandaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
