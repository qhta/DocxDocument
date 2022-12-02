namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IPicture? Picture { get ; set; }
  
}
