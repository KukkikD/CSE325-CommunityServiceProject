using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_CommunityServiceProject.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTaskHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedHours",
                table: "ServiceTasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EstimatedHours",
                table: "ServiceTasks",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
