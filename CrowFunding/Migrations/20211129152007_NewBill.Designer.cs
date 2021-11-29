﻿// <auto-generated />
using System;
using CrowFunding.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrowFunding.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    [Migration("20211129152007_NewBill")]
    partial class NewBill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrowFunding.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateInserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("ProjectBasketId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectCategory")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectBasketId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectBacker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectPageId")
                        .HasColumnType("int");

                    b.Property<int>("TotalSpent")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectPageId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectBackers");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectBasket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentAmount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GoalAmount")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectCategory")
                        .HasColumnType("int");

                    b.Property<int>("ProjectCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectStatusId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusUpdate")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TotalBackers")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectPage");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ProjectStatuses");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectTrending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProjectPageId")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectPageId");

                    b.ToTable("ProjectTrendings");
                });

            modelBuilder.Entity("CrowFunding.Domain.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateInserted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedShipping")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeeAmount")
                        .HasColumnType("int");

                    b.Property<string>("IncludeItems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectPageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectPageId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("CrowFunding.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CrowFunding.Domain.Project", b =>
                {
                    b.HasOne("CrowFunding.Domain.ProjectBasket", null)
                        .WithMany("Projects")
                        .HasForeignKey("ProjectBasketId");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectBacker", b =>
                {
                    b.HasOne("CrowFunding.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("CrowFunding.Domain.ProjectPage", null)
                        .WithMany("ProjectBacker")
                        .HasForeignKey("ProjectPageId");

                    b.HasOne("CrowFunding.Domain.User", null)
                        .WithMany("ProjectsBacker")
                        .HasForeignKey("UserId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectPage", b =>
                {
                    b.HasOne("CrowFunding.Domain.ProjectStatus", "ProjectStatus")
                        .WithMany("ProjectPages")
                        .HasForeignKey("ProjectStatusId");

                    b.HasOne("CrowFunding.Domain.User", "User")
                        .WithMany("ProjectPages")
                        .HasForeignKey("UserId");

                    b.Navigation("ProjectStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectTrending", b =>
                {
                    b.HasOne("CrowFunding.Domain.ProjectPage", "ProjectPage")
                        .WithMany()
                        .HasForeignKey("ProjectPageId");

                    b.Navigation("ProjectPage");
                });

            modelBuilder.Entity("CrowFunding.Domain.Reward", b =>
                {
                    b.HasOne("CrowFunding.Domain.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("CrowFunding.Domain.ProjectPage", null)
                        .WithMany("Reward")
                        .HasForeignKey("ProjectPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectBasket", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectPage", b =>
                {
                    b.Navigation("ProjectBacker");

                    b.Navigation("Reward");
                });

            modelBuilder.Entity("CrowFunding.Domain.ProjectStatus", b =>
                {
                    b.Navigation("ProjectPages");
                });

            modelBuilder.Entity("CrowFunding.Domain.User", b =>
                {
                    b.Navigation("ProjectPages");

                    b.Navigation("ProjectsBacker");
                });
#pragma warning restore 612, 618
        }
    }
}
