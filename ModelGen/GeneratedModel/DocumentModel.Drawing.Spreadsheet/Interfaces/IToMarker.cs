namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Ending Anchor Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IColumnOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IRowOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IColumnId))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IRowId))]
public interface IToMarker // : DocumentFormat.OpenXml.Drawing.Spreadsheet.MarkerType
{
  /// <summary>
  /// Column).
  /// </summary>
  public IColumnId? ColumnId { get ; set; }
  
  /// <summary>
  /// Column Offset.
  /// </summary>
  public IColumnOffset? ColumnOffset { get ; set; }
  
  /// <summary>
  /// Row.
  /// </summary>
  public IRowId? RowId { get ; set; }
  
  /// <summary>
  /// Row Offset.
  /// </summary>
  public IRowOffset? RowOffset { get ; set; }
  
}
