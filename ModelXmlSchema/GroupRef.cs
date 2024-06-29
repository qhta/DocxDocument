using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Represents a reference to a group of elements.
/// </summary>
public class GroupRef: Particle
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
