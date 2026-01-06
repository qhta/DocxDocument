namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic mosaic bubbles effect, which simulates a mosaic pattern with bubble-like textures and adjustable transparency and pressure.
/// </summary>
public interface ArtisticMosaicBubbles
{
  /// <summary>
  /// Gets or sets the transparency level of the mosaic bubbles effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the pressure applied in the mosaic bubbles effect, influencing the intensity and appearance of the bubbles.
  /// </summary>
  public Int32? Pressure { get; set; }
}