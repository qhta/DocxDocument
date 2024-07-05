using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Abstract class that represents a particle in a schema.
/// </summary>
[Index(nameof(OwnerNamespaceId), IsUnique = false)]
[Index(nameof(OwnerGroupId), IsUnique = false)]
[Index(nameof(OwnerTypeId), IsUnique = false)]
[Index(nameof(OwnerParticleId), IsUnique = false)]
public abstract class Particle
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Stores the type of the particle.
  /// </summary>
  [Column(TypeName = "byte")]
  public ParticleType ParticleType { get; set; }

  /// <summary>
  /// Identifier of the namespace of the schema where the particle is defined.
  /// Applies to global particles.
  /// </summary>
  public int? OwnerNamespaceId { get; set; }

  /// <summary>
  /// Identifier of the parent group.
  /// Applies to particles that are part of a group.
  /// </summary>
  public int? OwnerGroupId { get; set; }

  /// <summary>
  /// Identifier of the parent complex type.
  /// Applies to particles that are part of a complex type.
  /// </summary>
  public int? OwnerTypeId { get; set; }

  /// <summary>
  /// Identifier of the parent particle.
  /// Applies to particles that are declared inside another particle.
  /// </summary>
  public int? OwnerParticleId { get; set; }

  /// <summary>
  ///  Order number of the particle (from 1).
  /// </summary>
  public int? OrdNum { get; set; }

  /// <summary>
  /// Minimum number of occurrences of the particle.
  /// </summary>
  public int? MinOccurs { get; set; }

  /// <summary>
  /// Maximum number of occurrences of the particle. MaxInt indicates unbounded.
  /// </summary>
  public int? MaxOccurs { get; set; }

  /// <summary>
  /// Navigation property for the parent namespace.
  /// Exists only if the particle is a global particle.
  /// </summary>
  public Namespace? OwnerNamespace { get; set; }

  /// <summary>
  /// Navigation property for the parent complex type.
  /// Exists only if the particle is part of a complex type.
  /// </summary>
  public ComplexType? OwnerType { get; set; }

  /// <summary>
  /// Navigation property for the parent group.
  /// Exists only if the particle is part of a group.
  /// </summary>
  public ElementGroup? OwnerGroup { get; set; }

  /// <summary>
  /// Navigation property for the parent particle.
  /// Exists only if the particle is declared inside another particle.
  /// </summary>
  public ParticleGroup? OwnerParticle { get; set; }

  /// <summary>
  /// Returns the namespace that contains the particle directly or indirectly.
  /// </summary>
  [NotMapped]
  public Namespace? HostingNamespace =>
    OwnerNamespace ?? OwnerGroup?.OwnerNamespace ?? OwnerType?.OwnerNamespace;

}
