namespace DocumentModel.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public partial interface LineTo
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Point { get; set; }
  
}
