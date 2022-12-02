namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchies Class.
/// </summary>
public interface ICacheHierarchies // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hierarchy Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ICacheHierarchy>? CacheHierarchies { get ; set; }
  
}
