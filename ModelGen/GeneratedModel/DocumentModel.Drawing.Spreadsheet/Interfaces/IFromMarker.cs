namespace DocumentModel.Drawing.Spreadsheet;

public interface IFromMarker // : DocumentFormat.OpenXml.Drawing.Spreadsheet.MarkerType
{
  public IColumnId? ColumnId { get ; set; }

  public IColumnOffset? ColumnOffset { get ; set; }

  public IRowId? RowId { get ; set; }

  public IRowOffset? RowOffset { get ; set; }

}
