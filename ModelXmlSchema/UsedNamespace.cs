using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;


namespace ModelXmlSchema;


/// <summary>
///  Many-to-many relationship between SchemaFile and Namespace.
/// </summary>
[Index(nameof(FileId), IsUnique = false)]
[Index(nameof(NamespaceId), IsUnique = false)]
[PrimaryKey(nameof(FileId), nameof(NamespaceId))]
public class UsedNamespace
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the SchemaFile.
  /// </summary>
  public int FileId {get; set; }

  /// <summary>
  /// Unique identifier of the Namespace.
  /// </summary>
  public int NamespaceId { get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace used in the file.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Navigation property for the Namespace.
  /// </summary>
  public SchemaFile? SchemaFile { get; set; }

  /// <summary>
  /// Navigation property for the Namespace.
  /// </summary>
  public Namespace? SchemaNamespace { get; set; }
}
