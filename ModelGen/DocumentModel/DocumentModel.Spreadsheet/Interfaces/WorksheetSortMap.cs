namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet Sort Map.
/// </summary>
public interface WorksheetSortMap // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Row Sort Map.
  /// </summary>
  public RowSortMap? RowSortMap { get ; set; }
  
  /// <summary>
  /// Column Sort Map.
  /// </summary>
  public ColumnSortMap? ColumnSortMap { get ; set; }
  
}
