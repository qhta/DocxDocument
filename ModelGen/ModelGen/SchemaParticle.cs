using System.Runtime.Serialization;

namespace ModelGen;

[KnownType(typeof(ItemElementParticle))]
[KnownType(typeof(ItemsParticle))]
public abstract class SchemaParticle
{
  public ParticleType ParticleType { get; protected set; }

  public string? Name { get; set; }

  public bool IsRequired { get; set; }
  public bool IsMultiple { get; set; }

  public int? MinOccurs { get; set; }
  public int? MaxOccurs { get; set; }

  public int DefMinOccurs 
    => (IsRequired) ? 1 : 0;
  public int DefMaxOccurs 
    => (IsMultiple) ? int.MaxValue : 1;
}