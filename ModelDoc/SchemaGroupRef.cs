using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// Represents a reference to a group of elements.
/// </summary>
public class SchemaGroupRef: SchemaParticle
{

  /// <summary>
  /// Identifier of the namespace where the group is defined.
  /// Omitted if the group is defined in the same namespace as the reference.
  /// </summary>
  public int? RefNamespaceId { get; set; }

  /// <summary>
  /// Name of  the referred group.
  /// </summary>
  [MaxLength(255)]
  public string? RefName { get; set; }

}
