namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Stretch.
/// </summary>
public class Stretch: ModelElement
{
  /// <summary>
  ///   Fill IRectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
}
