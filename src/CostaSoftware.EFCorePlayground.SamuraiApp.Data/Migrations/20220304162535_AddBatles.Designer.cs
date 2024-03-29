﻿// <auto-generated />
using CostaSoftware.EFCorePlayground.SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CostaSoftware.EFCorePlayground.SamuraiApp.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20220304162535_AddBatles")]
    partial class AddBatles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BattleSamurai", b =>
                {
                    b.Property<int>("BattlesId")
                        .HasColumnType("int");

                    b.Property<int>("SamuraisId")
                        .HasColumnType("int");

                    b.HasKey("BattlesId", "SamuraisId");

                    b.HasIndex("SamuraisId");

                    b.ToTable("BattleSamurai");
                });

            modelBuilder.Entity("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("BattleSamurai", b =>
                {
                    b.HasOne("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Battle", null)
                        .WithMany()
                        .HasForeignKey("BattlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Samurai", null)
                        .WithMany()
                        .HasForeignKey("SamuraisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Quote", b =>
                {
                    b.HasOne("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Samurai", null)
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CostaSoftware.EFCorePlayground.SamuraiApp.Domain.Samurai", b =>
                {
                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
