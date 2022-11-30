namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Worksheet Drawing.
/// </summary>
public interface IWorksheetDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Drawing.Spreadsheet.ITwoCellAnchor? TwoCellAnchor { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IOneCellAnchor? OneCellAnchor { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.IAbsoluteAnchor? AbsoluteAnchor { get ; set; }
  
}
