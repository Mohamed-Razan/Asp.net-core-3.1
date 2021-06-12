using Microsoft.EntityFrameworkCore.Migrations;

namespace practice01.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ProfileId",
                table: "Student",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Profile_ProfileId",
                table: "Student",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Profile_ProfileId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_ProfileId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Student");
        }
    }
}
