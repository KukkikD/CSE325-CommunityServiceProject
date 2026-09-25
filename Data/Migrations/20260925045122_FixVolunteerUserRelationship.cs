using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_CommunityServiceProject.Migrations
{
    /// <inheritdoc />
    public partial class FixVolunteerUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSignups_AspNetUsers_VolunteerId",
                table: "VolunteerSignups");

            migrationBuilder.DropIndex(
                name: "IX_VolunteerSignups_VolunteerId",
                table: "VolunteerSignups");

            migrationBuilder.DropColumn(
                name: "VolunteerId",
                table: "VolunteerSignups");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSignups_AspNetUsers_VolunteerUserId",
                table: "VolunteerSignups",
                column: "VolunteerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VolunteerSignups_AspNetUsers_VolunteerUserId",
                table: "VolunteerSignups");

            migrationBuilder.AddColumn<string>(
                name: "VolunteerId",
                table: "VolunteerSignups",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerSignups_VolunteerId",
                table: "VolunteerSignups",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VolunteerSignups_AspNetUsers_VolunteerId",
                table: "VolunteerSignups",
                column: "VolunteerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
