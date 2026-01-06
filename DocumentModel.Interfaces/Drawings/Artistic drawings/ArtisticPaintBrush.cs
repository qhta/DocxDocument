namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic paint brush effect, which simulates a paint brush style with adjustable transparency and brush size.
/// </summary>
public interface ArtisticPaintBrush
{
  /// <summary>
  /// Gets or sets the transparency level of the paint brush effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the size of the brush used in the paint brush effect, influencing the thickness and coverage of the strokes.
  /// </summary>
  public Int32? BrushSize { get; set; }
}