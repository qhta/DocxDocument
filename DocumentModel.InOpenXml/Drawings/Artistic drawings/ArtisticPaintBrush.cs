namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic paint brush effect, which simulates a paint brush style with adjustable transparency and brush size.
/// </summary>
public class ArtisticPaintBrush: ModelElement<DXO10D.ArtisticPaintBrush>
{
  /// <summary>
  /// Transparency level of the paint brush effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Size of the brush used in the paint brush effect, influencing the thickness and coverage of the strokes.
  /// </summary>
  public Int32? BrushSize { get; set; }
}