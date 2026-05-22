using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolunteerTaskManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "VolunteerTaskManagement");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "VolunteerTaskManagement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "نام"),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "نام خانوادگی"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "نام کاربری"),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "آدرس ایمیل"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "هش پسوورد"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "نقش"),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "رفرش توکن"),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "انقضای رفرش توکن"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    LastModifyBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "VolunteerTaskManagement");
        }
    }
}
