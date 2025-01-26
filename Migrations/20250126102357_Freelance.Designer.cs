﻿// <auto-generated />
using System;
using FreeLance.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreeLance.Migrations
{
    [DbContext(typeof(FreelanceDbContext))]
    [Migration("20250126102357_Freelance")]
    partial class Freelance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FreeLance.Model.FreelanceUser", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UId");

                    b.ToTable("FreelanceUsers");
                });

            modelBuilder.Entity("FreeLance.Model.UHobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FreelanceUserUId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FreelanceUserUId");

                    b.ToTable("UHobbies");
                });

            modelBuilder.Entity("FreeLance.Model.USkillset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FreelanceUserUId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FreelanceUserUId");

                    b.ToTable("USkillsets");
                });

            modelBuilder.Entity("FreeLance.Model.UHobby", b =>
                {
                    b.HasOne("FreeLance.Model.FreelanceUser", null)
                        .WithMany("UHobbies")
                        .HasForeignKey("FreelanceUserUId");
                });

            modelBuilder.Entity("FreeLance.Model.USkillset", b =>
                {
                    b.HasOne("FreeLance.Model.FreelanceUser", null)
                        .WithMany("USkillsets")
                        .HasForeignKey("FreelanceUserUId");
                });

            modelBuilder.Entity("FreeLance.Model.FreelanceUser", b =>
                {
                    b.Navigation("UHobbies");

                    b.Navigation("USkillsets");
                });
#pragma warning restore 612, 618
        }
    }
}
