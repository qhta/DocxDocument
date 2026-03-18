namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    LineReference in ChartsStyle extends LineReference in Drawings with StyleColor.
/// </summary>
public class LineReference : DocumentModel.Drawings.LineReference
{
  /// <summary>
  /// Refers to color configuration for the line, allowing for detailed styling of chart lines such as solid colors, gradients, and pattern fills.
  /// </summary>

  public StyleColor? StyleColor { get; set; }
}