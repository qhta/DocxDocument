namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic glow edges effect, which simulates glowing edges with adjustable transparency and smoothness.
/// </summary>
public interface ArtisticGlowEdges
{
  /// <summary>
  /// Gets or sets the transparency level of the glow edges effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the smoothness of the glow edges effect, influencing the softness of the glow.
  /// </summary>
  public Int32? Smoothness { get; set; }
}