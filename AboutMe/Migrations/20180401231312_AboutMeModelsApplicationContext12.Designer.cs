﻿// <auto-generated />
using AboutMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AboutMe.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180401231312_AboutMeModelsApplicationContext12")]
    partial class AboutMeModelsApplicationContext12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AboutMe.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ObjectId");

                    b.Property<string>("ObjectType");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<DateTime>("fromDate");

                    b.Property<DateTime>("toDate");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("AboutMe.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Comment");

                    b.Property<int>("CompanyRating");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("AboutMe.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
