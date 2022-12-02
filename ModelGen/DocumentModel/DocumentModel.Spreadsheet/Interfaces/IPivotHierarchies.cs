namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchies Class.
/// </summary>
public interface IPivotHierarchies // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Hierarchy Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotHierarchy>? PivotHierarchies { get ; set; }
  
}
