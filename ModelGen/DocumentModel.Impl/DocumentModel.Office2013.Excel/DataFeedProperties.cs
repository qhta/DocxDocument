namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DataFeedProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDbTables))]
public class DataFeedProperties: IDataFeedProperties
{
  /// <summary>
  /// connection, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Connection
  {
    get;
    set;
  }
  
  /// <summary>
  /// DbTables.
  /// </summary>
  public IDbTables? DbTables
  {
    get;
    set;
  }
  
}
