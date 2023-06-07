using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace petsApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetTypes_petTypeid",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "petId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petTypeid",
                table: "Pets",
                newName: "petTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petTypeid",
                table: "Pets",
                newName: "IX_Pets_petTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetTypes_petTypeId",
                table: "Pets",
                column: "petTypeId",
                principalTable: "PetTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetTypes_petTypeId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petTypeId",
                table: "Pets",
                newName: "petTypeid");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petTypeId",
                table: "Pets",
                newName: "IX_Pets_petTypeid");

            migrationBuilder.AddColumn<int>(
                name: "petId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetTypes_petTypeid",
                table: "Pets",
                column: "petTypeid",
                principalTable: "PetTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
