using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Represents an attribute reference in a schema.
/// </summary>
public class AttributeRef: AttributeBase
{
  /// <summary>
  /// Initializes the type discriminator.
  /// </summary>
  public AttributeRef()
  {
    Type = AttributeType.AttributeRef;
  }

  /// <summary>
  /// Identifier of referenced attribute.
  /// </summary>
  [Required]
  public int RefAttributeId { get; set; }

}
