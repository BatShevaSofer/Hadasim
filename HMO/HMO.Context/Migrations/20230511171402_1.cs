using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMO.Context.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "PersonalDetailes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "PersonalDetailes");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalDetailesid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                    table.ForeignKey(
                        name: "FK_City_PersonalDetailes_PersonalDetailesid",
                        column: x => x.PersonalDetailesid,
                        principalTable: "PersonalDetailes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_PersonalDetailesid",
                table: "City",
                column: "PersonalDetailesid");
        }
    }
}
