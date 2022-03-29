﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sooziales_Netzwerk.Data;

#nullable disable

namespace Sooziales_Netzwerk.Migrations
{
    [DbContext(typeof(Sooziales_NetzwerkDbContext))]
    [Migration("20220329163155_Links")]
    partial class Links
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Sooziales_Netzwerk.Models.Link", b =>
                {
                    b.Property<int>("idLink")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("likes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("linkText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idLink");

                    b.ToTable("Link");
                });
#pragma warning restore 612, 618
        }
    }
}
