namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public interface ToMarker // : DocumentModel.Spreadsheet.Drawings.MarkerType
{
  public String? ColumnId { get ; set; }
  
  public String? ColumnOffset { get ; set; }
  
  public String? RowId { get ; set; }
  
  public String? RowOffset { get ; set; }
  
}
