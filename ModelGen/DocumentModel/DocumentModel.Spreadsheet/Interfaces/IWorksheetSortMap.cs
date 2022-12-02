namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet Sort Map.
/// </summary>
public interface IWorksheetSortMap // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Row Sort Map.
  /// </summary>
  public DocumentModel.Spreadsheet.IRowSortMap? RowSortMap { get ; set; }
  
  /// <summary>
  /// Column Sort Map.
  /// </summary>
  public DocumentModel.Spreadsheet.IColumnSortMap? ColumnSortMap { get ; set; }
  
}
