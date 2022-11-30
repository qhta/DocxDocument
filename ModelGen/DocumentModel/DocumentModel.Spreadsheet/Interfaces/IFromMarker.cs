namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FromMarker Class.
/// </summary>
public interface IFromMarker // : DocumentModel.Spreadsheet.IMarkerType
{
  public System.String? ColumnId { get ; set; }
  
  public System.String? ColumnOffset { get ; set; }
  
  public System.String? RowId { get ; set; }
  
  public System.String? RowOffset { get ; set; }
  
}
