namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Worksheet Drawing.
/// </summary>
public interface IWorksheetDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Spreadsheet.Drawing.ITwoCellAnchor? TwoCellAnchor { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IOneCellAnchor? OneCellAnchor { get ; set; }
  
  public DocumentModel.Spreadsheet.Drawing.IAbsoluteAnchor? AbsoluteAnchor { get ; set; }
  
}
