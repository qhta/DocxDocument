namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IMarkerType? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IExtent? Extent { get ; set; }
  
}
