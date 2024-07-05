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

}
