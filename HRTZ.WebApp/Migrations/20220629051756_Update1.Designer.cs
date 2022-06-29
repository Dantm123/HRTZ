﻿// <auto-generated />
using HRTZ.WebApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    [DbContext(typeof(HRTZDbContext))]
    [Migration("20220629051756_Update1")]
    partial class Update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("AdminCandidate", b =>
                {
                    b.Property<int>("CandidatesOnTestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TestersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CandidatesOnTestId", "TestersId");

                    b.HasIndex("TestersId");

                    b.ToTable("AdminCandidate");
                });

            modelBuilder.Entity("CandidateUser", b =>
                {
                    b.Property<int>("CandidatesOnTestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LikedById")
                        .HasColumnType("INTEGER");

                    b.HasKey("CandidatesOnTestId", "LikedById");

                    b.HasIndex("LikedById");

                    b.ToTable("CandidateUser");
                });

            modelBuilder.Entity("HRTZ.Core.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("HRTZ.Core.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeclined")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("OnTest")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkExperience")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("HRTZ.Core.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdminCandidate", b =>
                {
                    b.HasOne("HRTZ.Core.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesOnTestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRTZ.Core.Admin", null)
                        .WithMany()
                        .HasForeignKey("TestersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandidateUser", b =>
                {
                    b.HasOne("HRTZ.Core.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesOnTestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRTZ.Core.User", null)
                        .WithMany()
                        .HasForeignKey("LikedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
