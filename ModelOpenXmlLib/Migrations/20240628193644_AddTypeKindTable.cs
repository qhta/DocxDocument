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
      //migrationBuilder.CreateTable(
      //    name: "Files",
      //    columns: table => new
      //    {
      //        Val = table.Column<int>(type: "integer", nullable: false)
      //            .Annotation("Jet:Identity", "1, 1"),
      //        FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
      //    },
      //    constraints: table =>
      //    {
      //        table.PrimaryKey("PK_Files", x => x.Val);
      //    });

      //migrationBuilder.CreateTable(
      //    name: "Namespaces",
      //    columns: table => new
      //    {
      //        Val = table.Column<int>(type: "integer", nullable: false)
      //            .Annotation("Jet:Identity", "1, 1"),
      //        Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
      //        Prefix = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
      //    },
      //    constraints: table =>
      //    {
      //        table.PrimaryKey("PK_Namespaces", x => x.Val);
      //    });

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
      //migrationBuilder.CreateTable(
      //    name: "FileNamespaces",
      //    columns: table => new
      //    {
      //        FileId = table.Column<int>(type: "integer", nullable: false),
      //        NamespaceId = table.Column<int>(type: "integer", nullable: false)
      //    },
      //    constraints: table =>
      //    {
      //        table.PrimaryKey("PK_FileNamespaces", x => new { x.FileId, x.NamespaceId });
      //        table.ForeignKey(
      //            name: "FK_FileNamespaces_Files_FileId",
      //            column: x => x.FileId,
      //            principalTable: "Files",
      //            principalColumn: "Val",
      //            onDelete: ReferentialAction.Cascade);
      //        table.ForeignKey(
      //            name: "FK_FileNamespaces_Namespaces_NamespaceId",
      //            column: x => x.NamespaceId,
      //            principalTable: "Namespaces",
      //            principalColumn: "Val",
      //            onDelete: ReferentialAction.Cascade);
      //    });

      //migrationBuilder.CreateTable(
      //    name: "Types",
      //    columns: table => new
      //    {
      //        Val = table.Column<int>(type: "integer", nullable: false)
      //            .Annotation("Jet:Identity", "1, 1"),
      //        Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
      //        Kind = table.Column<byte>(type: "byte", nullable: false),
      //        IsAbstract = table.Column<bool>(type: "bit", nullable: false),
      //        NamespaceId = table.Column<int>(type: "integer", nullable: false)
      //    },
      //    constraints: table =>
      //    {
      //        table.PrimaryKey("PK_Types", x => x.Val);
      //        table.ForeignKey(
      //            name: "FK_Types_Namespaces_NamespaceId",
      //            column: x => x.NamespaceId,
      //            principalTable: "Namespaces",
      //            principalColumn: "Val",
      //            onDelete: ReferentialAction.Cascade);
      //    });

      //migrationBuilder.CreateIndex(
      //    name: "IX_FileNamespaces_FileId",
      //    table: "FileNamespaces",
      //    column: "FileId");

      //migrationBuilder.CreateIndex(
      //    name: "IX_FileNamespaces_NamespaceId",
      //    table: "FileNamespaces",
      //    column: "NamespaceId");

      //migrationBuilder.CreateIndex(
      //    name: "IX_Files_FileName",
      //    table: "Files",
      //    column: "FileName",
      //    unique: true);

      //migrationBuilder.CreateIndex(
      //    name: "IX_Namespaces_Name",
      //    table: "Namespaces",
      //    column: "Name",
      //    unique: true);

      //migrationBuilder.CreateIndex(
      //    name: "IX_Namespaces_Prefix",
      //    table: "Namespaces",
      //    column: "Prefix",
      //    unique: true,
      //    filter: "IGNORE NULL");

      //migrationBuilder.CreateIndex(
      //    name: "IX_Types_Kind",
      //    table: "Types",
      //    column: "Kind");

      //migrationBuilder.CreateIndex(
      //    name: "IX_Types_Name",
      //    table: "Types",
      //    column: "Name");

      //migrationBuilder.CreateIndex(
      //    name: "IX_Types_NamespaceId",
      //    table: "Types",
      //    column: "NamespaceId");

      //migrationBuilder.CreateIndex(
      //    name: "IX_Types_NamespaceId_Name",
      //    table: "Types",
      //    columns: new[] { "NamespaceId", "Name" },
      //    unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      //migrationBuilder.DropTable(
      //    name: "FileNamespaces");

      migrationBuilder.DropTable(
          name: "TypeKinds");

      //migrationBuilder.DropTable(
      //    name: "Types");

      //migrationBuilder.DropTable(
      //    name: "Files");

      //migrationBuilder.DropTable(
      //    name: "Namespaces");
    }
  }
}
