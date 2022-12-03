namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Worksheet Drawing.
/// </summary>
public interface WorksheetDrawing // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TwoCellAnchor>? TwoCellAnchors { get ; set; }
  
  public Collection<OneCellAnchor>? OneCellAnchors { get ; set; }
  
  public Collection<AbsoluteAnchor>? AbsoluteAnchors { get ; set; }
  
}
