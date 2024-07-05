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
  /// Identifier of the particle that defines the content model of the complex type.
  /// </summary>
  public int? ParticleId { get; set; }

  /// <summary>
  /// Attributes defined in the complex type.
  /// </summary>
  public virtual ICollection<AttributeBase> Attributes { get; set; } = new List<AttributeBase>();

  /// <summary>
  /// Dictionary of attribute definitions of the complex type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeBase> AttributesDictionary
  {
    get => _AttributesDictionary ??= new Dictionary<string, AttributeBase>();
    set => _AttributesDictionary = value;
  }
  private Dictionary<string, AttributeBase>? _AttributesDictionary;

  /// <summary>
  /// Navigation property to the particle that defines the content model of the complex type.
  /// </summary>
  public Particle? Particle { get; set; }
}
