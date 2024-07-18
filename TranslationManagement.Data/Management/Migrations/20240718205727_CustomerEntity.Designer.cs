﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranslationManagement.Data.Management;

#nullable disable

namespace TranslationManagement.Data.Management.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240718205727_CustomerEntity")]
    partial class CustomerEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.24");

            modelBuilder.Entity("TranslationManagement.Data.Management.CustomerRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CustomerRecord");
                });

            modelBuilder.Entity("TranslationManagement.Data.Management.JobRecrod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("TranslationManagement.Data.Management.PriceRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("TranslationManagement.Data.Management.TranslationRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("JobId")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("TranslatedContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("JobId");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("TranslationManagement.Data.Management.TranslatorRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HourlyRate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Translators");
                });

            modelBuilder.Entity("TranslationManagement.Data.Management.TranslationRecord", b =>
                {
                    b.HasOne("TranslationManagement.Data.Management.CustomerRecord", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TranslationManagement.Data.Management.JobRecrod", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Job");
                });
#pragma warning restore 612, 618
        }
    }
}
