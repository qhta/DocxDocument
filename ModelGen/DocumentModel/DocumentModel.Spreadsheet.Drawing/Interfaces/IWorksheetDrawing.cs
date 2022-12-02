namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Worksheet Drawing.
/// </summary>
public interface IWorksheetDrawing // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ITwoCellAnchor>? TwoCellAnchors { get ; set; }
  
  public Collection<IOneCellAnchor>? OneCellAnchors { get ; set; }
  
  public Collection<IAbsoluteAnchor>? AbsoluteAnchors { get ; set; }
  
}
