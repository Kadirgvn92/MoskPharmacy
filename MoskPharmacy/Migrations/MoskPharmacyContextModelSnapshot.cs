﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoskPharmacy.Context;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoskPharmacy.Migrations
{
    [DbContext(typeof(MoskPharmacyContext))]
    partial class MoskPharmacyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MoskPharmacy.Models.Drawing", b =>
                {
                    b.Property<int>("DrawingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DrawingId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Geometry>("Geometry")
                        .HasColumnType("geometry");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DrawingId");

                    b.ToTable("Drawings");
                });

            modelBuilder.Entity("MoskPharmacy.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Lat")
                        .HasColumnType("double precision");

                    b.Property<double>("Long")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MoskPharmacy.Models.Pharmacy", b =>
                {
                    b.Property<int>("PharmacyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PharmacyId"));

                    b.Property<string>("PharmacyDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PharmacyLat")
                        .HasColumnType("double precision");

                    b.Property<double>("PharmacyLong")
                        .HasColumnType("double precision");

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PharmacyId");

                    b.ToTable("Pharmacies");
                });
#pragma warning restore 612, 618
        }
    }
}
