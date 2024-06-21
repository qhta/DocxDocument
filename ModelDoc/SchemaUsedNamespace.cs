using System.ComponentModel.DataAnnotations;


namespace ModelDoc;


/// <summary>
///  Many-to-many relationship between SchemaFile and SchemaNamespace.
/// </summary>
public class SchemaUsedNamespace
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the SchemaFile.
  /// </summary>
  public int SchemaFileId {get; set; }

  /// <summary>
  /// Unique identifier of the SchemaNamespace.
  /// </summary>
  public int SchemaNamespaceId { get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace used in the file.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }
}
