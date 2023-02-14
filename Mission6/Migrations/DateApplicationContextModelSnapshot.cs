﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(MovieAdditionContext))]
    partial class DateApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_Tschen02.Models.ApplicationResponse", b =>
            {
                b.Property<int>("ApplicationId")
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

                b.Property<int>("Year")
                    .HasColumnType("INTEGER");

                b.HasKey("ApplicationId");

                b.ToTable("Responses");

                b.HasData(
                    new
                    {
                        ApplicationId = 1,
                        Category = "Action",
                        Director = "Brett Ratner",
                        Edited = false,
                        Rating = "PG-13",
                        Title = "Rush Hour 2",
                        Year = 2001
                    },
                    new
                    {
                        ApplicationId = 2,
                        Category = "Drama",
                        Director = "Mitch Davis",
                        Edited = true,
                        Rating = "PG-13",
                        Title = "The other Side of Heaven",
                        Year = 2001
                    },
                    new
                    {
                        ApplicationId = 3,
                        Category = "Action",
                        Director = "Brett Ratner",
                        Edited = false,
                        Rating = "PG-13",
                        Title = "Rush Hour 3",
                        Year = 2007
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
