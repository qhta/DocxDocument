namespace DocumentModel.Drawing;

/// <summary>
/// Path Gradient.
/// </summary>
public interface IPathGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public IRelativeRectangleType? FillToRectangle { get ; set; }
  
}
