﻿// <auto-generated />
using System;
using DAB_ASS2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_ASS2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220407083549_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAB_ASS2.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<DateTime>("booking_from")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("booking_to")
                        .HasColumnType("datetime2");

                    b.Property<int>("room_Id")
                        .HasColumnType("int");

                    b.Property<int>("society_Id")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DAB_ASS2.Models.Chairman", b =>
                {
                    b.Property<int>("chairmanid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("chairmanid"), 1L, 1);

                    b.Property<long>("chairman_CPR")
                        .HasColumnType("bigint");

                    b.Property<string>("chairman_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chairman_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("chairmanid");

                    b.ToTable("Chairmen");
                });

            modelBuilder.Entity("DAB_ASS2.Models.Location", b =>
                {
                    b.Property<int>("location_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("location_ID"), 1L, 1);

                    b.Property<string>("location_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("location_zipcode")
                        .HasColumnType("int");

                    b.HasKey("location_ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DAB_ASS2.Models.LocationProperty", b =>
                {
                    b.Property<int>("locationproperties_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("locationproperties_ID"), 1L, 1);

                    b.Property<string>("location_property_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationproperties_ID");

                    b.ToTable("LocationProperty");
                });

            modelBuilder.Entity("DAB_ASS2.Models.Room", b =>
                {
                    b.Property<int>("room_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("room_ID"), 1L, 1);

                    b.Property<int>("location_ID")
                        .HasColumnType("int");

                    b.Property<int>("room_capacity")
                        .HasColumnType("int");

                    b.Property<string>("room_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("room_ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DAB_ASS2.Models.RoomProperty", b =>
                {
                    b.Property<int>("roomproperties_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roomproperties_ID"), 1L, 1);

                    b.Property<string>("room_property_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roomproperties_ID");

                    b.ToTable("RoomProperty");
                });

            modelBuilder.Entity("DAB_ASS2.Models.Society", b =>
                {
                    b.Property<int>("society_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("society_ID"), 1L, 1);

                    b.Property<int>("chairmanid")
                        .HasColumnType("int");

                    b.Property<long>("society_CVR")
                        .HasColumnType("bigint");

                    b.Property<string>("society_activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("society_member_count")
                        .HasColumnType("int");

                    b.Property<string>("society_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("society_ID");

                    b.ToTable("Societies");
                });

            modelBuilder.Entity("LocationLocationProperty", b =>
                {
                    b.Property<int>("Locationslocation_ID")
                        .HasColumnType("int");

                    b.Property<int>("locationproperties_ID")
                        .HasColumnType("int");

                    b.HasKey("Locationslocation_ID", "locationproperties_ID");

                    b.HasIndex("locationproperties_ID");

                    b.ToTable("LocationLocationProperty");
                });

            modelBuilder.Entity("RoomRoomProperty", b =>
                {
                    b.Property<int>("Roomsroom_ID")
                        .HasColumnType("int");

                    b.Property<int>("roomproperties_ID")
                        .HasColumnType("int");

                    b.HasKey("Roomsroom_ID", "roomproperties_ID");

                    b.HasIndex("roomproperties_ID");

                    b.ToTable("RoomRoomProperty");
                });

            modelBuilder.Entity("LocationLocationProperty", b =>
                {
                    b.HasOne("DAB_ASS2.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("Locationslocation_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_ASS2.Models.LocationProperty", null)
                        .WithMany()
                        .HasForeignKey("locationproperties_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoomRoomProperty", b =>
                {
                    b.HasOne("DAB_ASS2.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("Roomsroom_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_ASS2.Models.RoomProperty", null)
                        .WithMany()
                        .HasForeignKey("roomproperties_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
