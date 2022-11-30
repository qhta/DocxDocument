namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IExtent? Extent { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IPicture? Picture { get ; set; }
  
}
