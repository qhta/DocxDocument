namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public interface IFromMarker // : DocumentModel.Spreadsheet.Drawing.IMarkerType
{
  public String? ColumnId { get ; set; }
  
  public String? ColumnOffset { get ; set; }
  
  public String? RowId { get ; set; }
  
  public String? RowOffset { get ; set; }
  
}
