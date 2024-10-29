using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelOpenXmlLib.Migrations
{
    /// <inheritdoc />
    public partial class AddProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    OrdNum = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    OwnerTypeId = table.Column<int>(type: "integer", nullable: false),
                    ValueTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Types_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Types_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Name",
                table: "Properties",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OrdNum",
                table: "Properties",
                column: "OrdNum");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerTypeId",
                table: "Properties",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerTypeId_Name",
                table: "Properties",
                columns: new[] { "OwnerTypeId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerTypeId_OrdNum",
                table: "Properties",
                columns: new[] { "OwnerTypeId", "OrdNum" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ValueTypeId",
                table: "Properties",
                column: "ValueTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
