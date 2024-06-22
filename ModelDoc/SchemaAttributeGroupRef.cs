using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// References an attribute group in a schema. Replaces attribute.
/// </summary>
public class SchemaAttributeGroupRef
{

  /// <summary>
  /// Unique identifier for the attribute group reference.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Identifier of the complex type that contains the attribute group reference.
  /// </summary>
  public int? ComplexTypeId { get; set; }

  /// <summary>
  /// Identifier of the attribute group that contains the attribute.
  /// </summary>
  public int? AttributeGroupId { get; set; }

  /// <summary>
  /// Identifier of the namespace of the attribute group that is referenced.
  /// Omitted if the referenced group namespace is the same as the parent complex type or parent attribute group namespace.
  /// </summary>
  public int? RefNamespaceId { get; set; }

  /// <summary>
  /// Name of the attribute group that is referenced.
  /// </summary>
  [MaxLength(255)]
  public string? RefName { get; set; }

}
