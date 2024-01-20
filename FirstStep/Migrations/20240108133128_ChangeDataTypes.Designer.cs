﻿// <auto-generated />
using System;
using FirstStep.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstStep.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240108133128_ChangeDataTypes")]
    partial class ChangeDataTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstStep.Models.Entities.Advertisement", b =>
                {
                    b.Property<int>("job_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("job_id"));

                    b.Property<string>("arrangement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("current_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeement_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("field_id")
                        .HasColumnType("int");

                    b.Property<int>("hrmanager_id")
                        .HasColumnType("int");

                    b.Property<bool>("is_experience_required")
                        .HasColumnType("bit");

                    b.Property<string>("job_benefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("job_number")
                        .HasColumnType("int");

                    b.Property<string>("job_other_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job_overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job_qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job_responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("posted_date")
                        .HasColumnType("datetime2");

                    b.Property<float>("salary")
                        .HasColumnType("real");

                    b.Property<DateTime>("submission_deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("job_id");

                    b.ToTable("Advertisements");
                });
#pragma warning restore 612, 618
        }
    }
}
