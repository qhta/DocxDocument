using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Represents an attribute definition in a schema.
/// </summary>
public class AttributeDef: AttributeBase
{
  /// <summary>
  /// Initializes the type discriminator.
  /// </summary>
  public AttributeDef()
  {
    Type = AttributeType.AttributeDef;
  }

  /// <summary>
  /// Identifier of the attribute value type.
  /// </summary>
  public int? ValueTypeId { get; set; }

  /// <summary>
  /// Default value of the attribute.
  /// </summary>
  [MaxLength(255)]
  public string? DefaultValue { get; set; }

  /// <summary>
  /// Indicates if the default attribute value is fixed.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool IsFixed { get; set; }

  /// <summary>
  /// Navigation property for the value type.
  /// </summary>
  public TypeDef ValueType { get; set; } = null!;
}
