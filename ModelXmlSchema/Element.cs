using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Represents an element in a schema.
/// </summary>
public class Element: Particle
{
  /// <summary>
  /// Identifier of the namespace that this element refers to.
  /// Applies to the element which is a reference to another element.
  /// </summary>
  public int? RefNamespaceId { get; set; }

  /// <summary>
  /// Name of this element or the referred element.
  /// </summary>
  [MaxLength(255)]
  public string? Name { get; set; }

  /// <summary>
  /// Identifier of the namespace that the type of the element refers to.
  /// Omitted if the type is defined in the same namespace as the element.
  /// </summary>
  public int? TypeNamespaceId { get; set; }

  /// <summary>
  /// Name of the type of this element.
  /// </summary>
  [MaxLength(255)]
  public string? TypeName { get; set; }

}
