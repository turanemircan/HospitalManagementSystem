using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(nullable: false, maxLength: 50),
                Surname = table.Column<string>(nullable: false, maxLength: 50),
                Identification = table.Column<string>(nullable: false, maxLength: 50),
                GsmNo = table.Column<string>(nullable: false, maxLength: 50),
                Password = table.Column<string>(nullable: false, maxLength: 50),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Users", x => x.Id);
            });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Branch = table.Column<string>(nullable: false, maxLength: 50),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AgainPassword = table.Column<string>(nullable: false, maxLength: 50),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
            name: "Secretarys",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false),
                LocationClinic = table.Column<string>(nullable: false, maxLength: 50),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Secretarys", x => x.Id);
                table.ForeignKey(
                    name: "FK_Secretarys_Users_Id",
                    column: x => x.Id,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
      name: "FK_Doktorlar_Kullanıcılar_Id",
      table: "Doktorlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Hastalar_Kullanıcılar_Id",
                table: "Hastalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Sekreterler_Kullanıcılar_Id",
                table: "Sekreterler");

            migrationBuilder.DropTable(
                name: "Sekreterler");

            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");
        }
    }
}
