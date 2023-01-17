using DocumentFormat.OpenXml.Validation.Schema;

namespace ModelGen;

public class MyParticleConstraint
{
  public ParticleType ParticleType { get; set; }

  public int MinOccurs { get; set; }

  public int MaxOccurs { get; set; }

  public string? Version { get; set; }


}