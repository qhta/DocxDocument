namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic mosaic bubbles effect, which simulates a mosaic pattern with bubble-like textures and adjustable transparency and pressure.
/// </summary>
public class ArtisticMosaicBubbles: ModelElement
{
  /// <summary>
  /// Transparency level of the mosaic bubbles effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Pressure applied in the mosaic bubbles effect, influencing the intensity and appearance of the bubbles.
  /// </summary>
  public Int32? Pressure { get; set; }
}