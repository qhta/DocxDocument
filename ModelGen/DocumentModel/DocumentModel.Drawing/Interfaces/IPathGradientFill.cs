namespace DocumentModel.Drawing;

/// <summary>
/// Path Gradient.
/// </summary>
public interface IPathGradientFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeValues? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public IFillToRectangle? FillToRectangle { get ; set; }
  
}
