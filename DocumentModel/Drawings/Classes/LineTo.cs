namespace DocumentModel.Drawings;

/// <summary>
///   Draw Line To.
/// </summary>
public class LineTo: ModelElement
{
  /// <summary>
  ///   Line end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}