namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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