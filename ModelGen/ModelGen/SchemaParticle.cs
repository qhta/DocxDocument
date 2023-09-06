using System.Runtime.Serialization;

namespace ModelGen;

[KnownType(typeof(ItemElementParticle))]
[KnownType(typeof(ItemsParticle))]
public abstract class SchemaParticle
{
  public ParticleType ParticleType { get; set; }

  public string? Name { get; set; }

  public bool IsOptional => MinOccurs == 0;
  public bool IsMultiple => MaxOccurs == 0 || MaxOccurs > 1;

  public int MinOccurs { get; set; }
  public int MaxOccurs { get; set; }

  public int DefaultMinOccurs 
    => (IsOptional) ? 0 : 1;
  public int DefaultMaxOccurs 
    => (IsMultiple) ? 0 : 1;
}