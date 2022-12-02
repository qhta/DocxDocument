namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IPosition? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IExtent? Extent { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IPicture? Picture { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IClientData? ClientData { get ; set; }
  
}
