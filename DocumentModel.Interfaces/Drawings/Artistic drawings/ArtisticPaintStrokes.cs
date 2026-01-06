namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic paint strokes effect, which simulates painted strokes with adjustable transparency and intensity.
/// </summary>
public interface ArtisticPaintStrokes
{
  /// <summary>
  /// Gets or sets the transparency level of the paint strokes effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the intensity of the paint strokes effect, influencing the strength and visibility of the strokes.
  /// </summary>
  public Int32? Intensity { get; set; }
}