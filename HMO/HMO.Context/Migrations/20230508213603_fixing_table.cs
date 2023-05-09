using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HMO.Context.Migrations
{
    /// <inheritdoc />
    public partial class fixing_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetailes_City_City1id",
                table: "PersonalDetailes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccination_PersonalDetailes_personalDetaileid",
                table: "Vaccination");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccination_Producer_producer1id",
                table: "Vaccination");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetailes_City1id",
                table: "PersonalDetailes");

            migrationBuilder.DropColumn(
                name: "identity",
                table: "Vaccination");

            migrationBuilder.DropColumn(
                name: "producer",
                table: "Vaccination");

            migrationBuilder.DropColumn(
                name: "City1id",
                table: "PersonalDetailes");

            migrationBuilder.RenameColumn(
                name: "producer1id",
                table: "Vaccination",
                newName: "producerid");

            migrationBuilder.RenameColumn(
                name: "personalDetaileid",
                table: "Vaccination",
                newName: "identityid");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccination_producer1id",
                table: "Vaccination",
                newName: "IX_Vaccination_producerid");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccination_personalDetaileid",
                table: "Vaccination",
                newName: "IX_Vaccination_identityid");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "PersonalDetailes",
                newName: "cityid");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_PersonalDetailes_cityid",
                table: "PersonalDetailes");

            migrationBuilder.RenameColumn(
                name: "producerid",
                table: "Vaccination",
                newName: "producer1id");

            migrationBuilder.RenameColumn(
                name: "identityid",
                table: "Vaccination",
                newName: "personalDetaileid");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccination_producerid",
                table: "Vaccination",
                newName: "IX_Vaccination_producer1id");

            migrationBuilder.RenameIndex(
                name: "IX_Vaccination_identityid",
                table: "Vaccination",
                newName: "IX_Vaccination_personalDetaileid");

            migrationBuilder.RenameColumn(
                name: "cityid",
                table: "PersonalDetailes",
                newName: "city");

            migrationBuilder.AddColumn<string>(
                name: "identity",
                table: "Vaccination",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "producer",
                table: "Vaccination",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "City1id",
                table: "PersonalDetailes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetailes_City1id",
                table: "PersonalDetailes",
                column: "City1id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetailes_City_City1id",
                table: "PersonalDetailes",
                column: "City1id",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_PersonalDetailes_personalDetaileid",
                table: "Vaccination",
                column: "personalDetaileid",
                principalTable: "PersonalDetailes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccination_Producer_producer1id",
                table: "Vaccination",
                column: "producer1id",
                principalTable: "Producer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
