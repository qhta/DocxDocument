namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
public interface IOneCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
  public IShape? Shape { get ; set; }
  
  public IGroupShape? GroupShape { get ; set; }
  
  public IGraphicFrame? GraphicFrame { get ; set; }
  
  public IConnectionShape? ConnectionShape { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
  public IClientData? ClientData { get ; set; }
  
}
