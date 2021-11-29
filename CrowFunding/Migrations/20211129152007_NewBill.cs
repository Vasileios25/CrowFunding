using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowFunding.Migrations
{
    public partial class NewBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Buckers_BuckerId",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Basket_BasketId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Creators_CreatorId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "BuckerProject");

            migrationBuilder.DropTable(
                name: "Creators");

            migrationBuilder.DropTable(
                name: "Buckers");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Basket_BuckerId",
                table: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_BasketId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BuckerId",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameColumn(
                name: "Photos",
                table: "Project",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Project",
                newName: "ProjectBasketId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CreatorId",
                table: "Project",
                newName: "IX_Project_ProjectBasketId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInserted",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProjectStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusUpdate = table.Column<bool>(type: "bit", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAmount = table.Column<int>(type: "int", nullable: false),
                    TotalBackers = table.Column<int>(type: "int", nullable: false),
                    GoalAmount = table.Column<int>(type: "int", nullable: false),
                    ProjectCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProjectCategory = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ProjectStatusId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPage_ProjectStatuses_ProjectStatusId",
                        column: x => x.ProjectStatusId,
                        principalTable: "ProjectStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPage_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSpent = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    ProjectPageId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectBackers_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBackers_ProjectPage_ProjectPageId",
                        column: x => x.ProjectPageId,
                        principalTable: "ProjectPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBackers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTrendings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Views = table.Column<int>(type: "int", nullable: false),
                    ProjectPageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTrendings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTrendings_ProjectPage_ProjectPageId",
                        column: x => x.ProjectPageId,
                        principalTable: "ProjectPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateInserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedShipping = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludeItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false),
                    FeeAmount = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    ProjectPageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rewards_ProjectPage_ProjectPageId",
                        column: x => x.ProjectPageId,
                        principalTable: "ProjectPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBackers_ProjectId",
                table: "ProjectBackers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBackers_ProjectPageId",
                table: "ProjectBackers",
                column: "ProjectPageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBackers_UserId",
                table: "ProjectBackers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPage_ProjectStatusId",
                table: "ProjectPage",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPage_UserId",
                table: "ProjectPage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTrendings_ProjectPageId",
                table: "ProjectTrendings",
                column: "ProjectPageId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_ProjectId",
                table: "Rewards",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_ProjectPageId",
                table: "Rewards",
                column: "ProjectPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Basket_ProjectBasketId",
                table: "Project",
                column: "ProjectBasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Basket_ProjectBasketId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "ProjectBackers");

            migrationBuilder.DropTable(
                name: "ProjectTrendings");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "ProjectPage");

            migrationBuilder.DropTable(
                name: "ProjectStatuses");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DateInserted",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameColumn(
                name: "ProjectBasketId",
                table: "Projects",
                newName: "CreatorId");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Projects",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_Project_ProjectBasketId",
                table: "Projects",
                newName: "IX_Projects_CreatorId");

            migrationBuilder.AddColumn<int>(
                name: "BuckerId",
                table: "Basket",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Buckers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buckers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuckerProject",
                columns: table => new
                {
                    BuckerId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuckerProject", x => new { x.BuckerId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_BuckerProject_Buckers_BuckerId",
                        column: x => x.BuckerId,
                        principalTable: "Buckers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuckerProject_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creators_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_BuckerId",
                table: "Basket",
                column: "BuckerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_BasketId",
                table: "Projects",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BuckerProject_ProjectId",
                table: "BuckerProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Creators_ProfileId",
                table: "Creators",
                column: "ProfileId",
                unique: true,
                filter: "[ProfileId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Buckers_BuckerId",
                table: "Basket",
                column: "BuckerId",
                principalTable: "Buckers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Basket_BasketId",
                table: "Projects",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Creators_CreatorId",
                table: "Projects",
                column: "CreatorId",
                principalTable: "Creators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
