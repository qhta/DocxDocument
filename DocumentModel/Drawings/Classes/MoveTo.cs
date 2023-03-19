namespace DocumentModel.Drawings;

/// <summary>
///   Move Path To.
/// </summary>
public class MoveTo: ModelElement
{
  /// <summary>
  ///   Move end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}