﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tourism.Models;

namespace tourism.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210215032604_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("tourism.Models.Transfer", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("endPlace")
                        .HasColumnType("TEXT");

                    b.Property<string>("endTime")
                        .HasColumnType("TEXT");

                    b.Property<long>("idSalesMan")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nameSalesMan")
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("startPlace")
                        .HasColumnType("TEXT");

                    b.Property<string>("startTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("stops")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Transfers");
                });
#pragma warning restore 612, 618
        }
    }
}
