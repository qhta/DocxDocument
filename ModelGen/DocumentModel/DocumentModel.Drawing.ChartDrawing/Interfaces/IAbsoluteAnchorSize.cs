namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
}
