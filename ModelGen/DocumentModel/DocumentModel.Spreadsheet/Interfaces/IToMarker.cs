namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ToMarker Class.
/// </summary>
public interface IToMarker // : DocumentModel.Spreadsheet.IMarkerType
{
  public System.String? ColumnId { get ; set; }
  
  public System.String? ColumnOffset { get ; set; }
  
  public System.String? RowId { get ; set; }
  
  public System.String? RowOffset { get ; set; }
  
}
