namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic chalk sketch effect, which simulates a chalk drawing with adjustable transparency and pressure.
/// </summary>
public class ArtisticChalkSketch: ModelElement<DXO10D.ArtisticChalkSketch>
{
  /// <summary>
  /// Transparency level of the chalk sketch effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Pressure applied in the chalk sketch effect, influencing the intensity of the strokes.
  /// </summary>
  public Int32? Pressure { get; set; }
}