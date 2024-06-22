using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// Complex type definition.
/// </summary>
public class SchemaComplexType
{
  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the namespace of the complex type.
  /// </summary>
  public int SchemaNamespaceId { get; set; }

  /// <summary>
  /// RefName of the complex type.
  /// </summary>
  [MaxLength(255)]
  public string? TypeName { get; set; }

  /// <summary>
  /// Identifier of the namespace of the base type.
  /// Omitted if the base type namespace is the same as the complex type namespace.
  /// </summary>
  public int? BaseNamespaceId { get; set; }

  /// <summary>
  /// RefName of the base type. It can be a simple type or a complex type.
  /// </summary>
  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

  /// <summary>
  /// Content type of the complex type.
  /// </summary>
  public ContentType ContentType { get; set; }
}
