namespace DocumentModel.Drawings;

/// <summary>
///   Draw Line To.
/// </summary>
public record LineTo
{
  /// <summary>
  ///   Line end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}