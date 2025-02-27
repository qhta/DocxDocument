﻿using System.Runtime.Serialization;

namespace ModelGen;

/// <summary>
/// Abstract <see cref="SchemaParticle"/> which holds item particles.
/// </summary>
[KnownType(typeof(ItemsSequenceParticle))]
[KnownType(typeof(ItemsChoiceParticle))]
[KnownType(typeof(ItemsGroupParticle))]
[KnownType(typeof(ItemsAllParticle))]
public abstract class ItemsParticle : SchemaParticle
{
  public Collection<SchemaParticle> Items { [DebuggerStepThrough] get; } = new Collection<SchemaParticle>();

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