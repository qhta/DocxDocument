using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Complex type definition.
/// </summary>
public class ComplexType: TypeDef
{
  /// <summary>
  /// Content type of the complex type.
  /// </summary>
  public ContentType ContentType { get; set; }

  /// <summary>
  /// Specifies if the complex type has attributes.
  /// </summary>
  [Column(TypeName = "bit")]
  public bool HasAttributes { get; set; }

  /// <summary>
  /// Attributes of the complex type.
  /// </summary>
  public virtual ICollection<AttributeDef> Attributes { get; set; } = null!;

  /// <summary>
  /// Dictionary of attribute definitions of the complex type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeDef> AttributesDictionary
  {
    get => _AttributesDictionary ??= new Dictionary<string, AttributeDef>();
    set => _AttributesDictionary = value;
  }

  private Dictionary<string, AttributeDef>? _AttributesDictionary;
}
