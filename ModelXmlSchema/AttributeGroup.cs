using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Represents a group of attributes which can be used in many places.
/// </summary>
[Index(nameof(OwnerNamespaceId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerNamespaceId), IsUnique = false)]
[Index(nameof(Name), IsUnique = false)]
public class AttributeGroup: AttributeBase
{
  /// <summary>
  /// Initializes the type discriminator.
  /// </summary>
  public AttributeGroup()
  {
    Type = AttributeType.AttributeGroup;
  }

  /// <summary>
  /// Attributes defined in the attribute group.
  /// </summary>
  public virtual ICollection<AttributeBase> Attributes { get; set; } = new List<AttributeBase>();

  /// <summary>
  /// Dictionary of attribute definitions of the attribute group.
  /// </summary>
  [NotMapped]
  public Dictionary<string, AttributeBase> AttributesDictionary
  {
    get => _AttributesDictionary ??= new Dictionary<string, AttributeBase>();
    set => _AttributesDictionary = value;
  }
  private Dictionary<string, AttributeBase>? _AttributesDictionary;

}
