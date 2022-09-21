﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie.Data.Access.Context;

#nullable disable

namespace Movie.Data.Access.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220920185051_a3")]
    partial class a3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblGeneralAudienceType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TblGeneralAudienceType");
                });

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TblGeneralAudienceTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TblMovieTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblGeneralAudienceTypeId");

                    b.HasIndex("TblMovieTypeId");

                    b.ToTable("TblMovie");
                });

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblMovieHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TblMovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TblMovieId");

                    b.ToTable("TblMovieHistory");
                });

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblMovieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TblMovieType");
                });

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblMovie", b =>
                {
                    b.HasOne("Movie.Data.Model.DatabaseModel.TblGeneralAudienceType", "TblGeneralAudienceType")
                        .WithMany()
                        .HasForeignKey("TblGeneralAudienceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.Data.Model.DatabaseModel.TblMovieType", "TblMovieType")
                        .WithMany()
                        .HasForeignKey("TblMovieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblGeneralAudienceType");

                    b.Navigation("TblMovieType");
                });

            modelBuilder.Entity("Movie.Data.Model.DatabaseModel.TblMovieHistory", b =>
                {
                    b.HasOne("Movie.Data.Model.DatabaseModel.TblMovie", "TblMovie")
                        .WithMany()
                        .HasForeignKey("TblMovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblMovie");
                });
#pragma warning restore 612, 618
        }
    }
}