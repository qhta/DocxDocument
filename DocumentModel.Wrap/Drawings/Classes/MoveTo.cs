namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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