namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column).
  /// </summary>
  public String? ColumnId { get ; set; }
  
  /// <summary>
  /// Column Offset.
  /// </summary>
  public String? ColumnOffset { get ; set; }
  
  /// <summary>
  /// Row.
  /// </summary>
  public String? RowId { get ; set; }
  
  /// <summary>
  /// Row Offset.
  /// </summary>
  public String? RowOffset { get ; set; }
  
}
