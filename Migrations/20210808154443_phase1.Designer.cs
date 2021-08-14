﻿// <auto-generated />
using System;
using DoteNetAzure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoteNetAzure.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20210808154443_phase1")]
    partial class phase1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("DoteNetAzure.Models.Todo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}