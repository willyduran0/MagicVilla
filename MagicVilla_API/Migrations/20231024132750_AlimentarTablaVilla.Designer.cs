﻿// <auto-generated />
using System;
using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20231024132750_AlimentarTablaVilla")]
    partial class AlimentarTablaVilla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Linda Villa a Las Afueras De Medellin",
                            FechaActualizacion = new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3324),
                            FechaCreacion = new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3306),
                            ImagenUrl = "",
                            MetrosCuadrados = 300,
                            Nombre = "VillaDuran",
                            Ocupantes = 15,
                            Tarifa = 3000000.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Linda Villa a Las Afueras De Pereira",
                            FechaActualizacion = new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3329),
                            FechaCreacion = new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3328),
                            ImagenUrl = "",
                            MetrosCuadrados = 200,
                            Nombre = "VillaDuran2",
                            Ocupantes = 15,
                            Tarifa = 2000000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
