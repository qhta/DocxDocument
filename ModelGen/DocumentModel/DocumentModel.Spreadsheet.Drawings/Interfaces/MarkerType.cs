namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface MarkerType // : DocumentModel.BaseTypes.ModelElement
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
