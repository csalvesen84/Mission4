﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220126013938_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action/Adventure",
                            Director = "George Lucas",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Star Wars Episode III: Revenge of the Sith",
                            Year = (short)2005
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy",
                            Director = "Jared Hess",
                            Edited = false,
                            Rating = "PG",
                            Title = "Napoleon Dynamite",
                            Year = (short)2004
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Western",
                            Director = "Quentin Tarantino",
                            Edited = true,
                            Rating = "R",
                            Title = "Django Unchained",
                            Year = (short)2012
                        },
                        new
                        {
                            MovieId = 4,
                            Category = "Action/Comedy",
                            Director = "Matthew Vaughn",
                            Edited = true,
                            Rating = "R",
                            Title = "Kingsman: The Secret Service",
                            Year = (short)2014
                        });
                });
#pragma warning restore 612, 618
        }
    }
}