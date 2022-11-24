namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
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
