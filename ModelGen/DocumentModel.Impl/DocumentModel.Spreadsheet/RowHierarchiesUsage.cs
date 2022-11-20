namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowHierarchiesUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowHierarchyUsage))]
public class RowHierarchiesUsage: IRowHierarchiesUsage
{
  /// <summary>
  /// Item Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
