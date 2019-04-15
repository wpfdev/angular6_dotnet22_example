﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using angular6_dotnet22_example.DAL;

namespace Test2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190415120101_SeedCategories")]
    partial class SeedCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("angular6_dotnet22_example.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsFollowToNewsletter");

                    b.Property<int>("OptionId");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int?>("OrderId");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Option", b =>
                {
                    b.HasOne("angular6_dotnet22_example.Models.Product", "Product")
                        .WithMany("Options")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Order", b =>
                {
                    b.HasOne("angular6_dotnet22_example.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("angular6_dotnet22_example.Models.Product", b =>
                {
                    b.HasOne("angular6_dotnet22_example.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("angular6_dotnet22_example.Models.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
