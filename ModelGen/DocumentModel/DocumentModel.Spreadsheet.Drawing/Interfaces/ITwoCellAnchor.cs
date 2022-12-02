namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
public interface ITwoCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public IToMarker? ToMarker { get ; set; }
  
  public IShape? Shape { get ; set; }
  
  public IGroupShape? GroupShape { get ; set; }
  
  public IGraphicFrame? GraphicFrame { get ; set; }
  
  public IConnectionShape? ConnectionShape { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
  public IClientData? ClientData { get ; set; }
  
}
