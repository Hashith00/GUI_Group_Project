﻿// <auto-generated />
using GUIProject.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GUIProject.Migrations
{
    [DbContext(typeof(UserDataContext))]
    [Migration("20230721025805_initail")]
    partial class initail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("GUIProject.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<double>("GPA")
                        .HasColumnType("REAL");

                    b.Property<double>("Module1")
                        .HasColumnType("REAL");

                    b.Property<double>("Module2")
                        .HasColumnType("REAL");

                    b.Property<double>("Module3")
                        .HasColumnType("REAL");

                    b.Property<double>("Module4")
                        .HasColumnType("REAL");

                    b.Property<double>("Module5")
                        .HasColumnType("REAL");

                    b.Property<double>("Module6")
                        .HasColumnType("REAL");

                    b.Property<double>("Module7")
                        .HasColumnType("REAL");

                    b.Property<double>("Module8")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GUIProject.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pasword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}