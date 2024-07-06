using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// References an attribute group in a schema. Replaces attribute.
/// </summary>
public class AttributeGroupRef: AttributeBase
{
  /// <summary>
  /// Initializes the type discriminator.
  /// </summary>
  public AttributeGroupRef()
  {
    Type = AttributeType.AttributeGroupRef;
  }

  /// <summary>
  /// Identifier of the attribute group that is referenced.
  /// </summary>
  [Required]
  public int RefGroupId { get; set; }

  /// <summary>
  /// Navigation property for the referenced attribute group.
  /// </summary>
  public AttributeGroup RefGroup { get; set; } = null!;
}
