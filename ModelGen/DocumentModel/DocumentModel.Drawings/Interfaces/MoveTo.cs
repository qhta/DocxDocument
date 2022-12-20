namespace DocumentModel.Drawings;

/// <summary>
/// Move Path To.
/// </summary>
public partial interface MoveTo
{
  /// <summary>
  /// Move end point.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Point { get; set; }
  
}
