namespace ModelXmlSchema;

/// <summary>
/// Represents a reference to a group of elements.
/// </summary>
public class ElementGroupRef: Particle
{

  /// <summary>
  /// Identifier of the referenced group.
  /// </summary>
  public int RefGroupId { get; set; }


  /// <summary>
  /// Navigation property for the referenced group.
  /// </summary>
  public ElementGroup RefGroup { get; set; } = null!;

}
