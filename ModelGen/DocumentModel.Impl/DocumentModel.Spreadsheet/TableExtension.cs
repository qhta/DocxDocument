namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITable))]
public class TableExtension: ITableExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
