namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// One Cell Anchor Shape Size.
/// </summary>
public interface IOneCellAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromMarker.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// Extent.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IExtent? Extent { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IPicture? Picture { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IClientData? ClientData { get ; set; }
  
}
