namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ToMarker Class.
/// </summary>
public interface ToMarker // : DocumentModel.Spreadsheet.MarkerType
{
  public String? ColumnId { get ; set; }
  
  public String? ColumnOffset { get ; set; }
  
  public String? RowId { get ; set; }
  
  public String? RowOffset { get ; set; }
  
}
