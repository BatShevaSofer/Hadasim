using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMO.Context.Migrations
{
    /// <inheritdoc />
    public partial class HMO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetailes",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<int>(type: "int", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_number = table.Column<int>(type: "int", nullable: false),
                    telephon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pelephon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vaccination_number = table.Column<int>(type: "int", nullable: false),
                    start_ill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_ill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City1id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetailes", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonalDetailes_City_City1id",
                        column: x => x.City1id,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccination",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_vaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    producer = table.Column<int>(type: "int", nullable: false),
                    personalDetaileid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    producer1id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccination", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vaccination_PersonalDetailes_personalDetaileid",
                        column: x => x.personalDetaileid,
                        principalTable: "PersonalDetailes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccination_Producer_producer1id",
                        column: x => x.producer1id,
                        principalTable: "Producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetailes_City1id",
                table: "PersonalDetailes",
                column: "City1id");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_personalDetaileid",
                table: "Vaccination",
                column: "personalDetaileid");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_producer1id",
                table: "Vaccination",
                column: "producer1id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccination");

            migrationBuilder.DropTable(
                name: "PersonalDetailes");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
