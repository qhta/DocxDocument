using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelOpenXmlLib.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "BaseTypeId",
                table: "Types",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_BaseTypeId",
                table: "Types",
                column: "BaseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Types_BaseTypeId",
                table: "Types",
                column: "BaseTypeId",
                principalTable: "Types",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Types_Types_BaseTypeId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_BaseTypeId",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "BaseTypeId",
                table: "Types");

         }
    }
}
