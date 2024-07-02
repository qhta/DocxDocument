using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Represents an attribute in a schema.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(Name), IsUnique = false)]
public class AttributeDef
{

  /// <summary>
  /// Unique identifier for the attribute.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Identifier of the complex type that contains the attribute.
  /// </summary>
  public int? OwnerTypeId { get; set; }
  
  /// <summary>
  /// Identifier of the attribute group that contains the attribute.
  /// </summary>
  public int? OwnerGroupId { get; set; }

  /// <summary>
  /// Identifier of the namespace of the global attribute.
  /// </summary>
  public int? OwnerNamespaceId { get; set; }

  /// <summary>
  /// Identifier of the namespace of the referenced attribute.
  /// </summary>
  public int? RefNamespaceId { get; set; }

  /// <summary>
  /// Name of the attribute.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

  /// <summary>
  /// Identifier of the namespace of the attribute type.
  /// Omitted if the attribute type namespace is the same as the schema namespace.
  /// </summary>
  public int? TypeNamespaceId { get; set; }

  /// <summary>
  /// RefName of the attribute type.
  /// </summary>
  [MaxLength(255)]
  public string? TypeName { get; set; }

  /// <summary>
  /// Indicates if the attribute is required or optional.
  /// </summary>
  public AttributeUse? Use { get; set; }

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
  /// Navigation property to the complex type that contains the attribute.
  /// </summary>
  public virtual ComplexType? OwnerType { get; set; }
}
