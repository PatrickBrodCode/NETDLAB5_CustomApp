﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETDLAB5_CustomApp.Models;

namespace NETDLAB5_CustomApp.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20221212231721_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NETDLAB5_CustomApp.Models.Customer", b =>
                {
                    b.Property<int>("customerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("customerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
