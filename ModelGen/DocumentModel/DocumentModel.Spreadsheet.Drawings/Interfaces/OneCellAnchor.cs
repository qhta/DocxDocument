namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
public interface OneCellAnchor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public FromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public Extent? Extent { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public GroupShape? GroupShape { get ; set; }
  
  public GraphicFrame? GraphicFrame { get ; set; }
  
  public ConnectionShape? ConnectionShape { get ; set; }
  
  public Picture? Picture { get ; set; }
  
  public ClientData? ClientData { get ; set; }
  
}
