using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Represents a group of schema particles.
/// </summary>
public abstract class ParticleGroup: Particle
{
  /// <summary>
  /// Navigation property for the particles contained in the group.
  /// </summary>
  public List<Particle> Items { get; set; } = new();

  /// <summary>
  /// Dictionary for the particles contained in the group. Particle ord number is the key.
  /// </summary>
  [NotMapped]
  public Dictionary<int, Particle> ItemsDictionary { get; set; } = new();

}
