namespace DocumentModel.Drawing;

/// <summary>
/// Path Gradient.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillToRectangle))]
public interface IPathGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShade? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IFillToRectangle? FillToRectangle { get ; set; }
  
}
