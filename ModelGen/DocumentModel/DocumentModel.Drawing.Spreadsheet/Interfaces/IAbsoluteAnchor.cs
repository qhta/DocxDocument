namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IPosition? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IExtent? Extent { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IPicture? Picture { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IClientData? ClientData { get ; set; }
  
}
