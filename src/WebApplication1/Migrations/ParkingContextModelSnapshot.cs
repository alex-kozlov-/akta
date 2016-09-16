using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ParkingContext))]
    partial class ParkingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Bicycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AddedDate");

                    b.Property<DateTime>("BoughtDate");

                    b.Property<string>("Color");

                    b.Property<decimal>("Cost");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<int?>("ParkingId");

                    b.Property<DateTime?>("RemovedDate");

                    b.HasKey("Id");

                    b.HasIndex("ParkingId");

                    b.ToTable("Bicycles");
                });

            modelBuilder.Entity("WebApplication1.Models.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<DateTime>("OpenedDate");

                    b.HasKey("Id");

                    b.ToTable("Parkings");
                });

            modelBuilder.Entity("WebApplication1.Models.Bicycle", b =>
                {
                    b.HasOne("WebApplication1.Models.Parking")
                        .WithMany("Bicycles")
                        .HasForeignKey("ParkingId");
                });
        }
    }
}
