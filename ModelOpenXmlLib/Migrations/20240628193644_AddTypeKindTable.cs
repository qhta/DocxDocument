using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelOpenXmlLib.Migrations
{
  /// <inheritdoc />
  public partial class AddTypeKindTable : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "TypeKinds",
          columns: table => new
          {
            Id = table.Column<int>(type: "byte", nullable: false),
            Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_TypeKinds", x => x.Id);
          });
      migrationBuilder.InsertData(
          table: "TypeKinds",
          columns: new[] { "Id", "Name" },
          values: new object[,]
            {
              { 0, "Value" },
              { 1, "Enum"},
              { 2, "Struct" },
              { 3, "Class" },
              { 4, "Interface" }
            });
     }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "TypeKinds");
   }
  }
}
