﻿// <auto-generated />
using DriftNews.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DriftNewsParser.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230818104800_RenameTables")]
    partial class RenameTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DriftNewsParser.Models.DriversFDPRO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Championship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hometown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sponsors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DriversFDPRO");
                });

            modelBuilder.Entity("DriftNewsParser.Models.DriversRDS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarEngine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Championship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DriversRDS");
                });

            modelBuilder.Entity("DriftNewsParser.Models.NewsRDS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Championship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NewsRDS");
                });

            modelBuilder.Entity("DriftNewsParser.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Championship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DriftNewsParser.Models.ResultsFDPRO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AllPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R7")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResultsFDPRO");
                });

            modelBuilder.Entity("DriftNewsParser.Models.ResultsRDS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AllPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("R7")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResultsRDS");
                });
#pragma warning restore 612, 618
        }
    }
}
