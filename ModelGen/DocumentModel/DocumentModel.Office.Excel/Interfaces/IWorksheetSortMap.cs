namespace DocumentModel.Office.Excel;

/// <summary>
/// Worksheet Sort Map.
/// </summary>
public interface IWorksheetSortMap // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Row Sort Map.
  /// </summary>
  public DocumentModel.Office.Excel.IRowSortMap? RowSortMap { get ; set; }
  
  /// <summary>
  /// Column Sort Map.
  /// </summary>
  public DocumentModel.Office.Excel.IColumnSortMap? ColumnSortMap { get ; set; }
  
}
