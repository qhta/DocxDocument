namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Draw ILine To.
/// </summary>
public class LineTo: ModelElement
{
  /// <summary>
  ///   ILine end point.
  /// </summary>
  public AdjustPoint2DType? IPoint { get; set; }
}
