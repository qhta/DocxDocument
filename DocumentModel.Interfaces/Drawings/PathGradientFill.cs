namespace DocumentModel.Drawings;
/// <summary>
///   Path Gradient.
/// </summary>
public interface PathGradientFill: GradientFill
{
  /// <summary>
  ///   Gradient Fill Path
  /// </summary>
  public PathShadeKind? Path { get; set; }
  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  public RelativeRectangleType? FillToRectangle { get; set; }
}