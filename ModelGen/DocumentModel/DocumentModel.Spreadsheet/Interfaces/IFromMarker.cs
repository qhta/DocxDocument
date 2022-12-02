namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FromMarker Class.
/// </summary>
public interface IFromMarker // : DocumentModel.Spreadsheet.IMarkerType
{
  public String? ColumnId { get ; set; }
  
  public String? ColumnOffset { get ; set; }
  
  public String? RowId { get ; set; }
  
  public String? RowOffset { get ; set; }
  
}
