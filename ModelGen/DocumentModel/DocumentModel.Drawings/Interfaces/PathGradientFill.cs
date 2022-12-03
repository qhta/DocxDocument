namespace DocumentModel.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public interface PathGradientFill // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public RelativeRectangleType? FillToRectangle { get ; set; }
  
}
