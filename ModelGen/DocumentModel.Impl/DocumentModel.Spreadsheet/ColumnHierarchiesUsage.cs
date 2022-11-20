namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnHierarchiesUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnHierarchyUsage))]
public class ColumnHierarchiesUsage: IColumnHierarchiesUsage
{
  /// <summary>
  /// Items Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
