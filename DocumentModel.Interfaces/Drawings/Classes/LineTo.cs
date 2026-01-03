namespace DocumentModel.Drawings;

/// <summary>
///   Draw Line To.
/// </summary>
public interface LineTo: IModelElement
{
  /// <summary>
  ///   Line end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}