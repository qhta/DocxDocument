namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Tight Wrapping.
/// </summary>
public interface WrapTight
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon { get ; set; }
  
}
