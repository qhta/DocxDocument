using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public abstract class SchemaParticle
{

  [Key] public int Id { get; set; }

  public ParticleType ParticleType { get; set; }

  public int? SchemaNamespaceId { get; set; }

  public int? GroupId { get; set; }

  public int? ComplexTypeId { get; set; }

  public int? ParentParticleId { get; set; }

  public int? OrdNum { get; set; }

  public int? MinOccurs { get; set; }

  public int? MaxOccurs { get; set; }

}
