namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Two Cell Anchor Shape Size.
/// </summary>
public interface ITwoCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Positioning and Resizing Behaviors
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.EditAsKind? EditAs { get ; set; }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IToMarker? ToMarker { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IPicture? Picture { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IClientData? ClientData { get ; set; }
  
}
