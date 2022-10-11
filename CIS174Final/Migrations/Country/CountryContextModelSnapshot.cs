﻿// <auto-generated />
using CIS174Final.Areas.AssignmentModule7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS174Final.Migrations.Country
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CIS174Final.Areas.AssignmentModule7.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS174Final.Areas.AssignmentModule7.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "can",
                            CategoryID = "indoor",
                            FlagImage = "ca.png",
                            GameID = "winter",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "swe",
                            CategoryID = "indoor",
                            FlagImage = "se.png",
                            GameID = "winter",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "gbe",
                            CategoryID = "indoor",
                            FlagImage = "gb.png",
                            GameID = "winter",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "jam",
                            CategoryID = "outdoor",
                            FlagImage = "jm.png",
                            GameID = "winter",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "ita",
                            CategoryID = "outdoor",
                            FlagImage = "it.png",
                            GameID = "winter",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "jap",
                            CategoryID = "outdoor",
                            FlagImage = "jp.png",
                            GameID = "winter",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "ger",
                            CategoryID = "indoor",
                            FlagImage = "de.png",
                            GameID = "summer",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "chi",
                            CategoryID = "indoor",
                            FlagImage = "cn.png",
                            GameID = "summer",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "mex",
                            CategoryID = "indoor",
                            FlagImage = "mx.png",
                            GameID = "summer",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "brz",
                            CategoryID = "outdoor",
                            FlagImage = "br.png",
                            GameID = "summer",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "ndr",
                            CategoryID = "outdoor",
                            FlagImage = "nl.png",
                            GameID = "summer",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            FlagImage = "us.png",
                            GameID = "summer",
                            Name = "United States"
                        },
                        new
                        {
                            CountryID = "tha",
                            CategoryID = "indoor",
                            FlagImage = "th.png",
                            GameID = "para",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "uru",
                            CategoryID = "indoor",
                            FlagImage = "uy.png",
                            GameID = "para",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CategoryID = "indoor",
                            FlagImage = "ua.png",
                            GameID = "para",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "aus",
                            CategoryID = "outdoor",
                            FlagImage = "at.png",
                            GameID = "para",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "pak",
                            CategoryID = "outdoor",
                            FlagImage = "pk.png",
                            GameID = "para",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "zim",
                            CategoryID = "outdoor",
                            FlagImage = "zw.png",
                            GameID = "para",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            CountryID = "fra",
                            CategoryID = "indoor",
                            FlagImage = "fr.png",
                            GameID = "youth",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CategoryID = "indoor",
                            FlagImage = "cy.png",
                            GameID = "youth",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "rus",
                            CategoryID = "indoor",
                            FlagImage = "ru.png",
                            GameID = "youth",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "fin",
                            CategoryID = "outdoor",
                            FlagImage = "fi.png",
                            GameID = "youth",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "slv",
                            CategoryID = "outdoor",
                            FlagImage = "sk.png",
                            GameID = "youth",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "por",
                            CategoryID = "outdoor",
                            FlagImage = "pt.png",
                            GameID = "youth",
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("CIS174Final.Areas.AssignmentModule7.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth Olympics"
                        });
                });

            modelBuilder.Entity("CIS174Final.Areas.AssignmentModule7.Models.Country", b =>
                {
                    b.HasOne("CIS174Final.Areas.AssignmentModule7.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CIS174Final.Areas.AssignmentModule7.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.Navigation("Category");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
