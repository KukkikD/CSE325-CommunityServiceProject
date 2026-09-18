using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_CommunityServiceProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCommunityConnectModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceOpportunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    OrganizerUserId = table.Column<string>(type: "TEXT", nullable: false),
                    OrganizerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOpportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOpportunities_AspNetUsers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EstimatedHours = table.Column<decimal>(type: "TEXT", nullable: false),
                    VolunteersNeeded = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceOpportunityId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTasks_ServiceOpportunities_ServiceOpportunityId",
                        column: x => x.ServiceOpportunityId,
                        principalTable: "ServiceOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerSignups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SignupDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ServiceTaskId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VolunteerUserId = table.Column<string>(type: "TEXT", nullable: false),
                    VolunteerId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerSignups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerSignups_AspNetUsers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerSignups_ServiceTasks_ServiceTaskId",
                        column: x => x.ServiceTaskId,
                        principalTable: "ServiceTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOpportunities_OrganizerId",
                table: "ServiceOpportunities",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTasks_ServiceOpportunityId",
                table: "ServiceTasks",
                column: "ServiceOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerSignups_ServiceTaskId",
                table: "VolunteerSignups",
                column: "ServiceTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerSignups_VolunteerId",
                table: "VolunteerSignups",
                column: "VolunteerId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerSignups_VolunteerUserId_ServiceTaskId",
                table: "VolunteerSignups",
                columns: new[] { "VolunteerUserId", "ServiceTaskId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerSignups");

            migrationBuilder.DropTable(
                name: "ServiceTasks");

            migrationBuilder.DropTable(
                name: "ServiceOpportunities");
        }
    }
}
