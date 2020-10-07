﻿// <auto-generated />
using DockerProject.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DockerProject.API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("DockerProject.API.Summary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Summary");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Freezing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bracing"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chilly"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cool"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mild"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Warm"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Balmy"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Hot"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Sweltering"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Scorching"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
