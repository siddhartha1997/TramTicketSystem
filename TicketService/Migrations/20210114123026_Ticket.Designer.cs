﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketService.Models;

namespace TicketService.Migrations
{
    [DbContext(typeof(TicketDBContext))]
    [Migration("20210114123026_Ticket")]
    partial class Ticket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TicketService.Models.TicketDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPassenger")
                        .HasColumnType("int");

                    b.Property<string>("Route")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TicketFare")
                        .HasColumnType("float");

                    b.Property<string>("TramType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TicketDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
