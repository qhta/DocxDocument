namespace DocumentModel.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public interface LineTo
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Point { get ; set; }
  
}
