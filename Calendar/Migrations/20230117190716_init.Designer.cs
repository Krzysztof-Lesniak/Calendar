﻿// <auto-generated />
using System;
using Calendar.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Calendar.Migrations
{
    [DbContext(typeof(CalendarDbContext))]
    [Migration("20230117190716_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Calendar.Models.CalendarObj", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CalendarObjects");
                });

            modelBuilder.Entity("Calendar.Models.CalendarTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CalendarID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CalendarObjId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CalendarObjId");

                    b.ToTable("CalendarTasks");
                });

            modelBuilder.Entity("Calendar.User", b =>
                {
                    b.Property<string>("_userName")
                        .HasColumnType("TEXT");

                    b.Property<string>("_password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("_role")
                        .HasColumnType("INTEGER");

                    b.HasKey("_userName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Calendar.Models.CalendarTask", b =>
                {
                    b.HasOne("Calendar.Models.CalendarObj", null)
                        .WithMany("TaskList")
                        .HasForeignKey("CalendarObjId");
                });

            modelBuilder.Entity("Calendar.Models.CalendarObj", b =>
                {
                    b.Navigation("TaskList");
                });
#pragma warning restore 612, 618
        }
    }
}