namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
public interface ITwoCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IToMarker? ToMarker { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IPicture? Picture { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IClientData? ClientData { get ; set; }
  
}
