using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Namespace defined in schema XSD file.
/// </summary>
public class SchemaNamespace
{

  /// <summary>
  /// Unique identifier of the namespace.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Url (long name) of the namespace.
  /// </summary>
  [MaxLength(255)]
  public string? Url {get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }
}
