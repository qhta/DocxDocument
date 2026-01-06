namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic chalk sketch effect, which simulates a chalk drawing with adjustable transparency and pressure.
/// </summary>
public interface ArtisticChalkSketch
{
  /// <summary>
  /// Gets or sets the transparency level of the chalk sketch effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the pressure applied in the chalk sketch effect, influencing the intensity of the strokes.
  /// </summary>
  public Int32? Pressure { get; set; }
}