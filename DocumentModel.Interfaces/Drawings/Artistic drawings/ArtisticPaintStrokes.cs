namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic paint strokes effect, which simulates painted strokes with adjustable transparency and intensity.
/// </summary>
public interface ArtisticPaintStrokes
{
  /// <summary>
  /// Transparency level of the paint strokes effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Intensity of the paint strokes effect, influencing the strength and visibility of the strokes.
  /// </summary>
  public Int32? Intensity { get; set; }
}