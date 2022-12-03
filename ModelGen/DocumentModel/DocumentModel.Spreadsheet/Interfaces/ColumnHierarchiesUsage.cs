namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnHierarchiesUsage Class.
/// </summary>
public interface ColumnHierarchiesUsage // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<HierarchyUsageType>? ColumnHierarchyUsages { get ; set; }
  
}
