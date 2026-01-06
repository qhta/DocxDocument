namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic cutout effect, which simulates a cutout style with adjustable transparency and number of shades.
/// </summary>
public interface ArtisticCutout
{
  /// <summary>
  /// Gets or sets the transparency level of the cutout effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the number of shades used in the cutout effect, influencing the visual depth and contrast.
  /// </summary>
  public Int32? NumberOfShades { get; set; }
}