namespace DocumentModel.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public interface LineTo // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public AdjustPoint2DType? Point { get ; set; }
  
}
