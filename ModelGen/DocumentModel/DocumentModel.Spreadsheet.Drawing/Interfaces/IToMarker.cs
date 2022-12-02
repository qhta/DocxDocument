namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public interface IToMarker // : DocumentModel.Spreadsheet.Drawing.IMarkerType
{
  public String? ColumnId { get ; set; }
  
  public String? ColumnOffset { get ; set; }
  
  public String? RowId { get ; set; }
  
  public String? RowOffset { get ; set; }
  
}
