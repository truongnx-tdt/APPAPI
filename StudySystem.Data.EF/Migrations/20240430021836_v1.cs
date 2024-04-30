using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudySystem.Data.EF.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CookieDatas",
                columns: table => new
                {
                    CUser = table.Column<string>(type: "text", nullable: false),
                    CookieData = table.Column<string>(type: "text", nullable: false),
                    CreateUser = table.Column<string>(type: "text", nullable: false),
                    UpdateUser = table.Column<string>(type: "text", nullable: false),
                    CreateDateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookieDatas", x => x.CUser);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "text", nullable: false),
                    UserFullName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreateUser = table.Column<string>(type: "text", nullable: false),
                    UpdateUser = table.Column<string>(type: "text", nullable: false),
                    CreateDateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookieDatas");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
