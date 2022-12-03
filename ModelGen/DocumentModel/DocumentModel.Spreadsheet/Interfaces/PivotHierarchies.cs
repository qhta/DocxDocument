namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchies Class.
/// </summary>
public interface PivotHierarchies // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// OLAP Hierarchy Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotHierarchy>? PivotHierarchies { get ; set; }
  
}
