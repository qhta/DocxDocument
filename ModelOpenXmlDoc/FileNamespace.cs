using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace ModelOpenXmlDoc;


/// <summary>
///  Many-to-many relationship between SchemaFile and SchemaNamespace.
/// </summary>
[Index(nameof(FileId), IsUnique=false)]
[Index(nameof(NamespaceId), IsUnique = false)]
[PrimaryKey(nameof(FileId), nameof(NamespaceId))]
public class FileNamespace
{
  /// <summary>
  /// Unique identifier of the SchemaFile.
  /// </summary>
  public int FileId {get; set; }

  /// <summary>
  /// Unique identifier of the SchemaNamespace.
  /// </summary>
  public int NamespaceId { get; set; }

}
