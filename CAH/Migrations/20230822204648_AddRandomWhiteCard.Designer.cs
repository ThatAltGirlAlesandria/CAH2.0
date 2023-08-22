﻿// <auto-generated />
using CAH.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CAH.Migrations
{
    [DbContext(typeof(CAHContext))]
    [Migration("20230822204648_AddRandomWhiteCard")]
    partial class AddRandomWhiteCard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CAH.Models.BlackCards", b =>
                {
                    b.Property<int>("BlackCardsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("BlackCardsId");

                    b.ToTable("BlackCards");
                });

            modelBuilder.Entity("CAH.Models.RandomWhiteCards", b =>
                {
                    b.Property<int>("RandomWhiteCardsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("RandomWhiteCardsId");

                    b.ToTable("RandomWhiteCard");
                });

            modelBuilder.Entity("CAH.Models.WhiteCards", b =>
                {
                    b.Property<int>("WhiteCardsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("WhiteCardsId");

                    b.ToTable("WhiteCards");
                });
#pragma warning restore 612, 618
        }
    }
}