using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeyzaNurYilmazHafta2WebAPI.Migrations
{
    public partial class feyzamig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bootcamps",
                columns: table => new
                {
                    BId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BDeadlineApp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bootcamps", x => x.BId);
                });

            migrationBuilder.CreateTable(
                name: "Student_Bootcamps",
                columns: table => new
                {
                    SId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Bootcamps", x => x.SId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_Bootcamps",
                columns: table => new
                {
                    TId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Bootcamps", x => x.TId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Student_Bootcamps");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teacher_Bootcamps");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
