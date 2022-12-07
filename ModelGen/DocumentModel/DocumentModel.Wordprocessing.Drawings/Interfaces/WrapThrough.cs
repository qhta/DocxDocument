namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Through Wrapping.
/// </summary>
public interface WrapThrough
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public WrapPolygon? WrapPolygon { get ; set; }
  
}
