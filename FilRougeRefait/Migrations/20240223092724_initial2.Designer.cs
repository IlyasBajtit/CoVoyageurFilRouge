﻿// <auto-generated />
using System;
using CoVoyageur.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoVoyageur.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240223092724_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoVoyageur.API.DTOs.FeedbackDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("DateHour")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Driver")
                        .HasColumnType("int");

                    b.Property<int>("ID_Passenger")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Driver");

                    b.HasIndex("ID_Passenger");

                    b.ToTable("FeedbackDTO");
                });

            modelBuilder.Entity("CoVoyageur.API.DTOs.ReservationDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ID_Passenger")
                        .HasColumnType("int");

                    b.Property<int>("ID_Ride")
                        .HasColumnType("int");

                    b.Property<int>("Statuts")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID_Passenger");

                    b.HasIndex("ID_Ride");

                    b.ToTable("ReservationDTO");
                });

            modelBuilder.Entity("CoVoyageur.API.DTOs.RideDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Arrival")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateHour")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Driver")
                        .HasColumnType("int");

                    b.Property<int>("NbPlaces")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("RideDTO");
                });

            modelBuilder.Entity("CoVoyageur.API.DTOs.UserDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("BirthDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("DrivingLicense")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("InscriptionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserDTO");
                });

            modelBuilder.Entity("CoVoyageur.API.DTOs.FeedbackDTO", b =>
                {
                    b.HasOne("CoVoyageur.API.DTOs.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("ID_Driver")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CoVoyageur.API.DTOs.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("ID_Passenger")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CoVoyageur.API.DTOs.ReservationDTO", b =>
                {
                    b.HasOne("CoVoyageur.API.DTOs.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("ID_Passenger")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoVoyageur.API.DTOs.RideDTO", null)
                        .WithMany()
                        .HasForeignKey("ID_Ride")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
