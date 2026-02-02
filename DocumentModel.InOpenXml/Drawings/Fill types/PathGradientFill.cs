namespace DocumentModel.Drawings;
/// <summary>
///   Represents a path gradient fill, which uses a gradient that follows a specified path and can be limited to a rectangle.
/// </summary>
public partial class PathGradientFill : GradientFill
{
  /// <summary>
  ///   Type of path used for the gradient fill.
  /// </summary>
  public PathShade? Path { get; set; }
  /// <summary>
  ///   Rectangle that limits the area affected by the gradient fill.
  /// </summary>
  public RelativeRectangleType? FillToRectangle { get; set; }
}