namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic diffused glow effect, which simulates a soft glowing appearance with adjustable transparency and intensity.
/// </summary>
public interface ArtisticGlowDiffused
{
  /// <summary>
  /// Gets or sets the transparency level of the diffused glow effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the intensity of the diffused glow effect, influencing the strength of the glow.
  /// </summary>
  public Int32? Intensity { get; set; }
}