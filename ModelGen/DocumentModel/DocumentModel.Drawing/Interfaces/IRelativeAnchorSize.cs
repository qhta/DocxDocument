namespace DocumentModel.Drawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface IRelativeAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.IToAnchor? ToAnchor { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.IPicture? Picture { get ; set; }
  
}
