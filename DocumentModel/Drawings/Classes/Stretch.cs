namespace DocumentModel.Drawings;

/// <summary>
///   Stretch.
/// </summary>
public record Stretch
{
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
}