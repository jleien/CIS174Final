﻿// <auto-generated />
using CIS174Final.Areas.TicketList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS174Final.Migrations.Ticket
{
    [DbContext(typeof(TicketContext))]
    [Migration("20221025214119_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CIS174Final.Areas.TicketList.Models.Sprint", b =>
                {
                    b.Property<string>("SprintId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SprintId");

                    b.ToTable("Sprints");

                    b.HasData(
                        new
                        {
                            SprintId = "1",
                            Number = "1"
                        },
                        new
                        {
                            SprintId = "2",
                            Number = "2"
                        },
                        new
                        {
                            SprintId = "3",
                            Number = "3"
                        },
                        new
                        {
                            SprintId = "4",
                            Number = "4"
                        },
                        new
                        {
                            SprintId = "5",
                            Number = "5"
                        });
                });

            modelBuilder.Entity("CIS174Final.Areas.TicketList.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "todo",
                            Name = "To-Do"
                        },
                        new
                        {
                            StatusId = "progress",
                            Name = "In Progress"
                        },
                        new
                        {
                            StatusId = "qa",
                            Name = "Quality Assurance"
                        },
                        new
                        {
                            StatusId = "closed",
                            Name = "Completed"
                        });
                });

            modelBuilder.Entity("CIS174Final.Areas.TicketList.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SprintId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pointId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("CIS174Final.Areas.TicketList.Models.Ticket", b =>
                {
                    b.HasOne("CIS174Final.Areas.TicketList.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
