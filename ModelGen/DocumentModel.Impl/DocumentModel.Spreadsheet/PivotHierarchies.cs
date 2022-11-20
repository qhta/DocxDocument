namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchies Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotHierarchy))]
public class PivotHierarchies: IPivotHierarchies
{
  /// <summary>
  /// OLAP Hierarchy Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
