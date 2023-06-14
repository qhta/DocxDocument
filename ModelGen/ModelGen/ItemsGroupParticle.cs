namespace ModelGen;

/// <summary>
/// <see cref="ItemsParticle"/> which declares a group of item particles which can occur in the owner type info.
/// Usually one item particle exists.
/// </summary>
public class ItemsGroupParticle: ItemsParticle
{
  public ItemsGroupParticle() { ParticleType=ParticleType.Group; }
}