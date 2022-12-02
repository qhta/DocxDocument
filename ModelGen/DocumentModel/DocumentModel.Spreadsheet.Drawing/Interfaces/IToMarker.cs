namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public interface IToMarker // : DocumentModel.Spreadsheet.Drawing.IMarkerType
{
  public System.String? ColumnId { get ; set; }
  
  public System.String? ColumnOffset { get ; set; }
  
  public System.String? RowId { get ; set; }
  
  public System.String? RowOffset { get ; set; }
  
}
