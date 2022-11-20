namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IQueryTable))]
public class QueryTableExtension: IQueryTableExtension
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
