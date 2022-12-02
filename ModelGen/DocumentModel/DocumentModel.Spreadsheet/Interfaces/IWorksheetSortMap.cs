namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet Sort Map.
/// </summary>
public interface IWorksheetSortMap // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Row Sort Map.
  /// </summary>
  public IRowSortMap? RowSortMap { get ; set; }
  
  /// <summary>
  /// Column Sort Map.
  /// </summary>
  public IColumnSortMap? ColumnSortMap { get ; set; }
  
}
