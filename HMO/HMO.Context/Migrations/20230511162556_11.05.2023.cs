using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMO.Context.Migrations
{
    /// <inheritdoc />
    public partial class _11052023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetailes_City_cityid",
                table: "PersonalDetailes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccination_PersonalDetailes_identityid",
                table: "Vaccination");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccination_Producer_producerid",
                table: "Vaccination");

            migrationBuilder.DropIndex(
                name: "IX_Vaccination_identityid",
                table: "Vaccination");

            migrationBuilder.DropIndex(
                name: "IX_Vaccination_producerid",
                table: "Vaccination");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetailes_cityid",
                table: "PersonalDetailes");

            migrationBuilder.DropColumn(
                name: "identityid",
                table: "Vaccination");

            migrationBuilder.DropColumn(
                name: "producerid",
                table: "Vaccination");

            migrationBuilder.DropColumn(
                name: "cityid",
                table: "PersonalDetailes");

            migrationBuilder.AddColumn<int>(
                name: "Vaccinationid",
                table: "Producer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vaccinationid",
                table: "PersonalDetailes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalDetailesid",
                table: "City",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producer_Vaccinationid",
                table: "Producer",
                column: "Vaccinationid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetailes_Vaccinationid",
                table: "PersonalDetailes",
                column: "Vaccinationid");

            migrationBuilder.CreateIndex(
                name: "IX_City_PersonalDetailesid",
                table: "City",
                column: "PersonalDetailesid");

            migrationBuilder.AddForeignKey(
                name: "FK_City_PersonalDetailes_PersonalDetailesid",
                table: "City",
                column: "PersonalDetailesid",
                principalTable: "PersonalDetailes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetailes_Vaccination_Vaccinationid",
                table: "PersonalDetailes",
                column: "Vaccinationid",
                principalTable: "Vaccination",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producer_Vaccination_Vaccinationid",
                table: "Producer",
                column: "Vaccinationid",
                principalTable: "Vaccination",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_PersonalDetailes_PersonalDetailesid",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetailes_Vaccination_Vaccinationid",
                table: "PersonalDetailes");

            migrationBuilder.DropForeignKey(
                name: "FK_Producer_Vaccination_Vaccinationid",
                table: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_Producer_Vaccinationid",
                table: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetailes_Vaccinationid",
                table: "PersonalDetailes");

            migrationBuilder.DropIndex(
                name: "IX_City_PersonalDetailesid",
                table: "City");

            migrationBuilder.DropColumn(
                name: "Vaccinationid",
                table: "Producer");

            migrationBuilder.DropColumn(
                name: "Vaccinationid",
                table: "PersonalDetailes");

            migrationBuilder.DropColumn(
                name: "PersonalDetailesid",
                table: "City");

            migrationBuilder.AddColumn<string>(
                name: "identityid",
                table: "Vaccination",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "producerid",
                table: "Vaccination",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cityid",
                table: "PersonalDetailes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_identityid",
                table: "Vaccination",
                column: "identityid");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccination_producerid",
                table: "Vaccination",
                column: "producerid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetailes_cityid",
                table: "PersonalDetailes",
                column: "cityid");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetailes_City_cityid",
                table: "PersonalDetailes",
                column: "cityid",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_PersonalDetailes_identityid",
                table: "Vaccination",
                column: "identityid",
                principalTable: "PersonalDetailes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_Producer_producerid",
                table: "Vaccination",
                column: "producerid",
                principalTable: "Producer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
