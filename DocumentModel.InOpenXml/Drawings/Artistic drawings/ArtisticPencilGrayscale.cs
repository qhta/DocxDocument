namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic pencil grayscale effect, which simulates a pencil sketch in grayscale with adjustable transparency and brush size.
/// </summary>
public interface ArtisticPencilGrayscale
{
  /// <summary>
  /// Transparency level of the pencil grayscale effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Size of the brush used in the pencil grayscale effect, influencing the thickness and coverage of the strokes.
  /// </summary>
  public Int32? BrushSize { get; set; }
}