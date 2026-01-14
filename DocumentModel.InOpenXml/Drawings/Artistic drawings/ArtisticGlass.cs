namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic glass effect, which simulates a glass-like appearance with adjustable transparency and scaling.
/// </summary>
public class ArtisticGlass: ModelElement
{
  /// <summary>
  /// Transparency level of the glass effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Scaling factor for the glass effect, influencing the distortion and texture.
  /// </summary>
  public Int32? Scaling { get; set; }
}