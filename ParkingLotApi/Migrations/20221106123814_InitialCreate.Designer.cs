﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingLotApi.Repository;

#nullable disable

namespace ParkingLotApi.Migrations
{
    [DbContext(typeof(ParkingLotContext))]
    [Migration("20221106123814_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkingLotApi.Models.Order", b =>
                {
                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CloseTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreateTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameOfParkingLot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ParkingLotId")
                        .HasColumnType("int");

                    b.Property<string>("carPlateNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OrderNumber");

                    b.HasIndex("ParkingLotId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ParkingLotApi.Models.ParkingLot", b =>
                {
                    b.Property<int>("ParkingLotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ParkingLotCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ParkingLotLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ParkingLotName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ParkingLotId");

                    b.ToTable("ParkingLots");
                });

            modelBuilder.Entity("ParkingLotApi.Models.Order", b =>
                {
                    b.HasOne("ParkingLotApi.Models.ParkingLot", null)
                        .WithMany("OrdersListEntity")
                        .HasForeignKey("ParkingLotId");
                });

            modelBuilder.Entity("ParkingLotApi.Models.ParkingLot", b =>
                {
                    b.Navigation("OrdersListEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
