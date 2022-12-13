namespace DocumentModel.Wordprocessing.Drawings;

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
  public DocumentModel.Wordprocessing.Drawings.Point2DType? StartPoint { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.Point2DType? LineTo { get ; set; }
  
}
