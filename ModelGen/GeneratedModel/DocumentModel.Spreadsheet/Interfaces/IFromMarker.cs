namespace DocumentModel.Spreadsheet;

public interface IFromMarker // : DocumentFormat.OpenXml.Spreadsheet.MarkerType
{
  public IColumnId? ColumnId { get ; set; }
  
  public IColumnOffset? ColumnOffset { get ; set; }
  
  public IRowId? RowId { get ; set; }
  
  public IRowOffset? RowOffset { get ; set; }
  
}
