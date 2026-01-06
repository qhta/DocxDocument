namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic pastels smooth effect, which simulates a smooth pastel drawing style with adjustable transparency and brush size.
/// </summary>
public interface ArtisticPastelsSmooth
{
  /// <summary>
  /// Gets or sets the transparency level of the pastels smooth effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the size of the brush used in the pastels smooth effect, influencing the smoothness and coverage of the strokes.
  /// </summary>
  public Int32? BrushSize { get; set; }
}