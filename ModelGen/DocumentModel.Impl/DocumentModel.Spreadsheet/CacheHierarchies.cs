namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchies Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheHierarchy))]
public class CacheHierarchies: ICacheHierarchies
{
  /// <summary>
  /// Hierarchy Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
