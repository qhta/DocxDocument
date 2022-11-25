namespace DocumentModel.Drawing;

/// <summary>
/// Path Gradient.
/// </summary>
public interface IPathGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public DocumentModel.Drawing.PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IRelativeRectangleType? FillToRectangle { get ; set; }
  
}
