namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public interface WrapPolygon
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  public Boolean? Edited { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Point2DType? StartPoint { get ; set; }
  
  public DocumentModel.Drawings.Wordprocessing.Point2DType? LineTo { get ; set; }
  
}
