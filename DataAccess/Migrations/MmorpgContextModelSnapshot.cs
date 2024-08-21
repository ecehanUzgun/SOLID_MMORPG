﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MmorpgContext))]
    partial class MmorpgContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Irk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Irklar");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IrkId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SilahId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CharacterId");

                    b.HasIndex("IrkId");

                    b.HasIndex("SilahId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Silah", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("HasarOranı")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Silahlar");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Player", b =>
                {
                    b.HasOne("DataAccess.Entities.Abstracts.Character", "Character")
                        .WithMany("Player")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Abstracts.Irk", "Irk")
                        .WithMany("Player")
                        .HasForeignKey("IrkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Abstracts.Silah", "Silah")
                        .WithMany("Player")
                        .HasForeignKey("SilahId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Irk");

                    b.Navigation("Silah");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Character", b =>
                {
                    b.Navigation("Player");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Irk", b =>
                {
                    b.Navigation("Player");
                });

            modelBuilder.Entity("DataAccess.Entities.Abstracts.Silah", b =>
                {
                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
