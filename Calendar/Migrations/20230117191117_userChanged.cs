using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Migrations
{
    /// <inheritdoc />
    public partial class userChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_role",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "_password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "_userName",
                table: "Users",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "_role");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "_password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "_userName");
        }
    }
}
