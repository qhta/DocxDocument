namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSetHeader Class.
/// </summary>
public class TupleSetHeader: ITupleSetHeader
{
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? UniqueName
  {
    get;
    set;
  }
  
  /// <summary>
  /// hierarchyName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? HierarchyName
  {
    get;
    set;
  }
  
}
