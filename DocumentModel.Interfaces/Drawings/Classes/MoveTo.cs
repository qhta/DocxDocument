namespace DocumentModel.Drawings;

/// <summary>
///   Move Path To.
/// </summary>
public interface MoveTo: IModelElement
{
  /// <summary>
  ///   Move end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}