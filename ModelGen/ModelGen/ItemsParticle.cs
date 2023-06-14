namespace ModelGen;

/// <summary>
/// Abstract <see cref="SchemaParticle"/> which holds item particles.
/// </summary>
public abstract class ItemsParticle : SchemaParticle
{
  public Collection<SchemaParticle> Items { get; } = new Collection<SchemaParticle>();

  public static ItemsParticle Create(ParticleType particleType)
  {
    switch (particleType)
    {
      case ParticleType.Group:
        return new ItemsGroupParticle();
      case ParticleType.Sequence:
        return new ItemsSequenceParticle();
      case ParticleType.Choice:
        return new ItemsChoiceParticle();
      case ParticleType.All:
        return new ItemsAllParticle();
      default:
        throw new Qhta.TestHelper.InvalidOperationException($"ParticleType {particleType} not implemented");
    }
  }
}