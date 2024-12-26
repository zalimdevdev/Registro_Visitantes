﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroVisitantes.Models;

#nullable disable

namespace RegistroVisitantes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241222002531_InitialVisitanteMigration")]
    partial class InitialVisitanteMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RegistroVisitantes.Models.InfoVisitante", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("EdadVisitantes")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("NumeroTelefono")
                        .HasColumnType("int");

                    b.Property<string>("PaisDeOrigen")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InfoVisitantes");
                });
#pragma warning restore 612, 618
        }
    }
}
