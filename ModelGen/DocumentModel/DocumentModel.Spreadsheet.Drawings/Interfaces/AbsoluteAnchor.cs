namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface AbsoluteAnchor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public Position? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public Extent? Extent { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public GroupShape? GroupShape { get ; set; }
  
  public GraphicFrame? GraphicFrame { get ; set; }
  
  public ConnectionShape? ConnectionShape { get ; set; }
  
  public Picture? Picture { get ; set; }
  
  public ClientData? ClientData { get ; set; }
  
}
