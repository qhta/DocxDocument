namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Columns.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITableColumn))]
public class TableColumns: ITableColumns
{
  /// <summary>
  /// Column Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
