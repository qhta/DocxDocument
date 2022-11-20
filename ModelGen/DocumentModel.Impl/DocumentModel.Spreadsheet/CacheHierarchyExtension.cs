namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICacheHierarchy))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ICacheHierarchy))]
public class CacheHierarchyExtension: ICacheHierarchyExtension
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
