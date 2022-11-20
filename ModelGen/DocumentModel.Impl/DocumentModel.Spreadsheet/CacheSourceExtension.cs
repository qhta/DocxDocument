namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISourceConnection))]
public class CacheSourceExtension: ICacheSourceExtension
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
