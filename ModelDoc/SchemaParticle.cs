using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// Abstract class that represents a particle in a schema.
/// </summary>
public abstract class SchemaParticle
{

  /// <summary>
  /// Unique identifier of the entity.
  /// </summary>
  [Key] public int Id { get; set; }

  /// <summary>
  /// Stores the type of the particle.
  /// </summary>
  public ParticleType ParticleType { get; set; }

  /// <summary>
  /// Identifier of the namespace of the schema where the particle is defined.
  /// Applies to global particles.
  /// </summary>
  public int? SchemaNamespaceId { get; set; }

  /// <summary>
  /// Identifier of the parent group.
  /// Applies to particles that are part of a group.
  /// </summary>
  public int? GroupId { get; set; }

  /// <summary>
  /// Identifier of the parent complex type.
  /// Applies to particles that are part of a complex type.
  /// </summary>
  public int? ComplexTypeId { get; set; }

  /// <summary>
  /// Identifier of the parent particle.
  /// Applies to particles that are declared inside another particle.
  /// </summary>
  public int? ParentParticleId { get; set; }

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
  public SchemaNamespace? ParentNamespace { get; set; }

  /// <summary>
  /// Navigation property for the parent complex type.
  /// Exists only if the particle is part of a complex type.
  /// </summary>
  public SchemaComplexType? ParentComplexType { get; set; }

  /// <summary>
  /// Navigation property for the parent group.
  /// Exists only if the particle is part of a group.
  /// </summary>
  public SchemaGroup? ParentGroup { get; set; }

  /// <summary>
  /// Navigation property for the parent particle.
  /// Exists only if the particle is declared inside another particle.
  /// </summary>
  public SchemaParticle? ParentParticle { get; set; }

  public SchemaNamespace? OwnerNamespace => ParentNamespace ?? ParentComplexType?.ParentNamespace ?? ParentGroup?.ParentNamespace;// ?? ParentParticle?.OwnerNamespace;
}
