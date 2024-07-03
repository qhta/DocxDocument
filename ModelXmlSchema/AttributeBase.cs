using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using static Azure.Core.HttpHeader;

namespace ModelXmlSchema;

/// <summary>
/// Abstract attribute class.
/// Base class for attribute definition, attribute group, attribute reference and attribute group reference classes.
/// </summary>
[Index(nameof(OwnerTypeId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(OwnerNamespaceId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerNamespaceId), IsUnique = false)]
[Index(nameof(OwnerGroupId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerGroupId), IsUnique = false)]
[Index(nameof(Name), IsUnique = false)]
public abstract class AttributeBase
{

  /// <summary>
  /// Unique identifier for the attribute.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Classification of the attribute.
  /// </summary>
  [Column(TypeName = "byte")]
  public AttributeType Type { get; set; }

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
  /// Name of the attribute.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

  /// <summary>
  /// Indicates if the attribute is required or optional.
  /// </summary>
  public AttributeUse? Use { get; set; }

  /// <summary>
  /// Navigation property to the complex type that contains the attribute.
  /// </summary>
  public virtual ComplexType? OwnerType { get; set; }

  /// <summary>
  /// Navigation property to the attribute group that directly contains the attribute.
  /// </summary>
  public virtual AttributeGroup? OwnerGroup { get; set; }

  /// <summary>
  /// Navigation property to the namespace that directly contains the attribute.
  /// </summary>
  public virtual Namespace? OwnerNamespace { get; set; }

  /// <summary>
  /// Full name of the attribute containing the namespace prefix and the name.
  /// </summary>
  [NotMapped]
  public string FullName => Name.Contains(':') ? Name : ((OwnerNamespace?.Prefix ?? OwnerType?.Namespace.Prefix ?? OwnerGroup?.OwnerNamespace.Prefix) + ":" + Name);

  /// <summary>
  /// Returns the full name of the attribute.
  /// </summary>
  /// <param name="ns">Namespace that contains this attribute directly or indirectly</param>
  /// <param name="name">Name of the attribute</param>
  /// <returns></returns>
  public static string GetFullName(Namespace ns, string name)
  {
    return name.Contains(':') ? name : (ns.Prefix + ":" + name);
  }
}
