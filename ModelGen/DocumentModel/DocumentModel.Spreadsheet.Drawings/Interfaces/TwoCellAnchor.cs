namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
public interface TwoCellAnchor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public FromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public ToMarker? ToMarker { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public GroupShape? GroupShape { get ; set; }
  
  public GraphicFrame? GraphicFrame { get ; set; }
  
  public ConnectionShape? ConnectionShape { get ; set; }
  
  public Picture? Picture { get ; set; }
  
  public ClientData? ClientData { get ; set; }
  
}
