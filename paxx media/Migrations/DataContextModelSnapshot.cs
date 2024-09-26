﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using paxx_media.Models;

#nullable disable

namespace paxx_media.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("paxx_media.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Comment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SpaceID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("paxx_media.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "alice@example.com",
                            Name = "Alice Smith",
                            PasswordHash = "hashedpassword1",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 2,
                            Email = "bob@example.com",
                            Name = "Bob Johnson",
                            PasswordHash = "hashedpassword2",
                            Role = "Data Analyst"
                        },
                        new
                        {
                            ID = 3,
                            Email = "charlie@example.com",
                            Name = "Charlie Brown",
                            PasswordHash = "hashedpassword3",
                            Role = "scrum master"
                        },
                        new
                        {
                            ID = 4,
                            Email = "ali@example.com",
                            Name = "Ali Shah",
                            PasswordHash = "hashedpassword5",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 5,
                            Email = "bon@example.com",
                            Name = "Bon Johnson",
                            PasswordHash = "hashedpassword9",
                            Role = "Data Analyst"
                        },
                        new
                        {
                            ID = 6,
                            Email = "Juhi@example.com",
                            Name = "Juhi Brown",
                            PasswordHash = "hashedpassword7",
                            Role = "scrum master"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
