namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowHierarchiesUsage Class.
/// </summary>
public interface RowHierarchiesUsage // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<HierarchyUsageType>? RowHierarchyUsages { get ; set; }
  
}
