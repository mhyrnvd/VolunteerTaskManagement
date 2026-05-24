using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolunteerTaskManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "VolunteerTaskManagement",
                table: "Users",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "آدرس ایمیل",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComment: "آدرس ایمیل");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "VolunteerTaskManagement",
                table: "Users",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                comment: "آدرس ایمیل",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "آدرس ایمیل");
        }
    }
}
