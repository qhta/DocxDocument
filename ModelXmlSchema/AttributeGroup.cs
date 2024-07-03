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
public class AttributeGroup
{
  /// <summary>
  /// Unique identifier for the attribute.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// Identifier of the namespace of the global attribute.
  /// </summary>
  [Required]
  public int OwnerNamespaceId { get; set; }

  /// <summary>
  /// Name of the attribute.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

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


  /// <summary>
  /// Navigation property to the namespace that directly contains the attribute.
  /// </summary>
  public virtual Namespace OwnerNamespace { get; set; } = null!;

  /// <summary>
  /// Full name of the attribute containing the namespace prefix and the name.
  /// </summary>
  [NotMapped]
  public string FullName => (OwnerNamespace.Prefix) + ":" + Name;

  /// <summary>
  /// Returns the full name of the attribute.
  /// </summary>
  /// <param name="ns">Namespace that contains this attribute directly or indirectly</param>
  /// <param name="name">Name of the attribute</param>
  /// <returns></returns>
  public static string GetFullName(Namespace ns, string name)
  {
    return ns.Prefix + ":" + name;
  }
}
