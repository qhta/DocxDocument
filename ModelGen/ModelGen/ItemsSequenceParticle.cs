namespace ModelGen;

/// <summary>
/// <see cref="ItemsParticle"/> which declares that a sequence of item particles can occur in the owner type info.
/// </summary>
public class ItemsSequenceParticle: ItemsParticle
{
  public ItemsSequenceParticle() { ParticleType=ParticleType.Sequence; }

}