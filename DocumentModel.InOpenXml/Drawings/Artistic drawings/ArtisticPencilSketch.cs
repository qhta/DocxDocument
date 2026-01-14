namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic pencil sketch effect, which simulates a pencil sketch style with adjustable transparency and pressure.
/// </summary>
public interface ArtisticPencilSketch
{
  /// <summary>
  /// Transparency level of the pencil sketch effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Pressure applied in the pencil sketch effect, influencing the intensity and darkness of the strokes.
  /// </summary>
  public Int32? Pressure { get; set; }
}