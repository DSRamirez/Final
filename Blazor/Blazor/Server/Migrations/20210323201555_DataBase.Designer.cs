﻿// <auto-generated />
using System;
using Blazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blazor.Server.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20210323201555_DataBase")]
    partial class DataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blazor.Server.Models.Peluqueros", b =>
                {
                    b.Property<int>("Id_Peluquero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dia_Y_Horario_Disponible")
                        .HasColumnType("datetime2");

                    b.Property<string>("Peluquero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Peluquero");

                    b.ToTable("Peluqueros");
                });

            modelBuilder.Entity("Blazor.Server.Models.Productos", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Producto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Blazor.Server.Models.Servicios", b =>
                {
                    b.Property<int>("Id_Servicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Productos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tiempo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Servicio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Blazor.Server.Models.Turnos", b =>
                {
                    b.Property<int>("Id_Turno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dia_Y_Hora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nº_Turno")
                        .HasColumnType("int");

                    b.Property<string>("Peluquero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Turno");

                    b.ToTable("Turnos");
                });
#pragma warning restore 612, 618
        }
    }
}
