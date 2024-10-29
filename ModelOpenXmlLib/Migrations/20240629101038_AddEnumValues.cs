using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelOpenXmlLib.Migrations
{
    /// <inheritdoc />
    public partial class AddEnumValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnumValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    OrdNum = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    OwnerTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnumValues_Types_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnumValues_OwnerTypeId_Name",
                table: "EnumValues",
                columns: new[] { "OwnerTypeId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnumValues_OwnerTypeId_OrdNum",
                table: "EnumValues",
                columns: new[] { "OwnerTypeId", "OrdNum" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnumValues");
        }
    }
}
