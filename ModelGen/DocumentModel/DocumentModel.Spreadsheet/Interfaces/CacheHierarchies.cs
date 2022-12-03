namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchies Class.
/// </summary>
public interface CacheHierarchies // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Hierarchy Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<CacheHierarchy>? CacheHierarchies { get ; set; }
  
}
