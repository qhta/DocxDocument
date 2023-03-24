namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Stretch.
/// </summary>
public class Stretch: ModelElement
{
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
}