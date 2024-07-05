using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Represents a group of elements defined in a namespace.
/// </summary>
[Index(nameof(OwnerNamespaceId), nameof(Name), IsUnique = true)]
[Index(nameof(OwnerNamespaceId), IsUnique = false)]
[Index(nameof(Name), IsUnique = false)]
public class ElementGroup
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Unique identifier of the namespace where this group is defined.
  /// </summary>
  public int OwnerNamespaceId { get; set; }

  /// <summary>
  /// Name of the group.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

  /// <summary>
  /// Identifier of the particle that defines the content model of the element group.
  /// </summary>
  public int? ParticleId { get; set; }

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

  /// <summary>
  /// Navigation property to the particle that defines the content model of the element group.
  /// </summary>
  public ParticleGroup? Particle { get; set; }

}
