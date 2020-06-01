using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToddlerGrowthApp.Migrations
{
    public partial class baby1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 250, nullable: false),
                    Password = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Babies",
                columns: table => new
                {
                    BabyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BabyName = table.Column<string>(maxLength: 300, nullable: false),
                    BabySex = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    BirthWeight = table.Column<decimal>(nullable: false),
                    BirthHeight = table.Column<decimal>(nullable: false),
                    Bmi = table.Column<decimal>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Babies", x => x.BabyId);
                    table.ForeignKey(
                        name: "FK_Babies_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SleepingRecord",
                columns: table => new
                {
                    SleepingTrackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    BabyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepingRecord", x => x.SleepingTrackId);
                    table.ForeignKey(
                        name: "FK_SleepingRecord_Babies_BabyId",
                        column: x => x.BabyId,
                        principalTable: "Babies",
                        principalColumn: "BabyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Babies_UserEmail",
                table: "Babies",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_SleepingRecord_BabyId",
                table: "SleepingRecord",
                column: "BabyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SleepingRecord");

            migrationBuilder.DropTable(
                name: "Babies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
