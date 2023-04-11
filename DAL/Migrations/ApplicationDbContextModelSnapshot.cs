﻿// <auto-generated />
using System;
using DAL.DataCantext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Car", b =>
                {
                    b.Property<string>("RegisterNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Modify")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OwnerPersonId")
                        .HasColumnType("int");

                    b.HasKey("RegisterNumber");

                    b.HasIndex("OwnerPersonId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            RegisterNumber = "415 GTA",
                            Color = "Red",
                            Create = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3777),
                            Model = "volo"
                        });
                });

            modelBuilder.Entity("Domain.City", b =>
                {
                    b.Property<string>("PostNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.HasKey("PostNumber");

                    b.HasIndex("CountryName");

                    b.ToTable("cities");

                    b.HasData(
                        new
                        {
                            PostNumber = "415 52",
                            CityName = "Östersund",
                            Create = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3872)
                        });
                });

            modelBuilder.Entity("Domain.Continent", b =>
                {
                    b.Property<string>("ContinentName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.HasKey("ContinentName");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            ContinentName = "EURO",
                            Create = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3845)
                        });
                });

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.Property<string>("CountryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ContinentName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Create")
                        .HasColumnType("datetime2");

                    b.HasKey("CountryName");

                    b.HasIndex("ContinentName");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryName = "danmark",
                            Create = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3809)
                        });
                });

            modelBuilder.Entity("Domain.House", b =>
                {
                    b.Property<int>("HouseNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseNumber"));

                    b.Property<string>("CityPostNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modify")
                        .HasColumnType("datetime2");

                    b.HasKey("HouseNumber");

                    b.HasIndex("CityPostNumber");

                    b.ToTable("Houses");

                    b.HasData(
                        new
                        {
                            HouseNumber = 1,
                            Create = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3741)
                        });
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.Property<string>("JobName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("JobName");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            JobName = "programer",
                            Salary = 35000
                        });
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("CityPostNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EfterName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modify")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonId");

                    b.HasIndex("CityPostNumber");

                    b.HasIndex("HouseNumber");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 11111111,
                            Birthday = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3639),
                            EfterName = "khawari",
                            Name = "Ali",
                            Register = new DateTime(2023, 4, 10, 16, 54, 5, 208, DateTimeKind.Local).AddTicks(3706)
                        });
                });

            modelBuilder.Entity("JobPerson", b =>
                {
                    b.Property<string>("JobsJobName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PeoplePersonId")
                        .HasColumnType("int");

                    b.HasKey("JobsJobName", "PeoplePersonId");

                    b.HasIndex("PeoplePersonId");

                    b.ToTable("JobPerson");

                    b.HasData(
                        new
                        {
                            JobsJobName = "programer",
                            PeoplePersonId = 11111111
                        });
                });

            modelBuilder.Entity("Domain.Car", b =>
                {
                    b.HasOne("Domain.Person", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerPersonId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Domain.City", b =>
                {
                    b.HasOne("Domain.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryName");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.HasOne("Domain.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentName");

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("Domain.House", b =>
                {
                    b.HasOne("Domain.City", "City")
                        .WithMany("Houses")
                        .HasForeignKey("CityPostNumber");

                    b.Navigation("City");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.HasOne("Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityPostNumber");

                    b.HasOne("Domain.House", "House")
                        .WithMany("People")
                        .HasForeignKey("HouseNumber");

                    b.Navigation("City");

                    b.Navigation("House");
                });

            modelBuilder.Entity("JobPerson", b =>
                {
                    b.HasOne("Domain.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsJobName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Person", null)
                        .WithMany()
                        .HasForeignKey("PeoplePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.City", b =>
                {
                    b.Navigation("Houses");
                });

            modelBuilder.Entity("Domain.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Domain.House", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}