namespace ModelGen;

/// <summary>
/// <see cref="ItemsParticle"/> which declares that only chosen of item particles can occur in the owner type info.
/// </summary>
public class ItemsChoiceParticle: ItemsParticle
{
  public ItemsChoiceParticle() { ParticleType=ParticleType.Choice; }
}