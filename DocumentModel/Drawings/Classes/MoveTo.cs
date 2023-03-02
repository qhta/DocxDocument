namespace DocumentModel.Drawings;

/// <summary>
///   Move Path To.
/// </summary>
public record MoveTo
{
  /// <summary>
  ///   Move end point.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}