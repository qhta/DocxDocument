using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// SchemaFile represents an XSD file.
/// </summary>
public class SchemaFile
{
  /// <summary>
  ///   Unique identifier for the SchemaFile.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  ///  The name of the file (without path and extension).
  /// </summary>
  [MaxLength(255)] public string? FileName { get; set; }

  /// <summary>
  /// Unique identifier for the namespace defined in the file.
  /// </summary>
  public int? TargetNamespaceId { get; set; }

  /// <summary>
  /// Navigation property for the namespace defined in the file.
  /// </summary>
  public SchemaNamespace? TargetNamespace { get; set; }

}
