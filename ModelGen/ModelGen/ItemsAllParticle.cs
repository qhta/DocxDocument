namespace ModelGen;

/// <summary>
/// <see cref="ItemsParticle"/> which declares that all item particles must appear in the owner type info.
/// </summary>
public class ItemsAllParticle: ItemsParticle
{
  public ItemsAllParticle() { ParticleType=ParticleType.All; }
}