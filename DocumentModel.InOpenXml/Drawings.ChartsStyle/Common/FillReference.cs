namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    FillReference in ChartsStyle extends FillReference in Drawings with StyleColor.
/// </summary>
public class FillReference : DocumentModel.Drawings.FillReference
{
  /// <summary>
  /// Refers to color configuration for the fill, allowing for detailed styling of chart fills such as solid colors, gradients, and pattern fills.
  /// </summary>

  public StyleColor? StyleColor { get; set; }
}