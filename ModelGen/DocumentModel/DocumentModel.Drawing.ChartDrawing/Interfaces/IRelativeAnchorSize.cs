namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface IRelativeAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IToAnchor? ToAnchor { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IPicture? Picture { get ; set; }
  
}
