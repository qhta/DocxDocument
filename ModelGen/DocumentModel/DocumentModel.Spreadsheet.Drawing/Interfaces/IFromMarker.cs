namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public interface IFromMarker // : DocumentModel.Spreadsheet.Drawing.IMarkerType
{
  public System.String? ColumnId { get ; set; }
  
  public System.String? ColumnOffset { get ; set; }
  
  public System.String? RowId { get ; set; }
  
  public System.String? RowOffset { get ; set; }
  
}
