﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pecanha.Repository.Context;

namespace Pecanha.Repository.Migrations
{
    [DbContext(typeof(SceneContext))]
    partial class SceneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Pecanha.Domain.Entity.RecordHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActualState")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ActualState");

                    b.Property<DateTime>("OperationHour")
                        .HasColumnType("TEXT")
                        .HasColumnName("OperationHour");

                    b.Property<int>("PreviousState")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PreviousState");

                    b.Property<int>("SceneId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SceneId");

                    b.ToTable("RecordHistory");
                });

            modelBuilder.Entity("Pecanha.Domain.Entity.Scene", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT")
                        .HasColumnName("LastUpdate");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.Property<DateTime>("OperationHour")
                        .HasColumnType("TEXT")
                        .HasColumnName("OperationHour");

                    b.Property<DateTime>("RegisteringDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("RegisteringDate");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER")
                        .HasColumnName("State");

                    b.HasKey("Id");

                    b.ToTable("Scene");
                });

            modelBuilder.Entity("Pecanha.Domain.Entity.RecordHistory", b =>
                {
                    b.HasOne("Pecanha.Domain.Entity.Scene", "Scene")
                        .WithMany("RecordHistories")
                        .HasForeignKey("SceneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scene");
                });

            modelBuilder.Entity("Pecanha.Domain.Entity.Scene", b =>
                {
                    b.Navigation("RecordHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
