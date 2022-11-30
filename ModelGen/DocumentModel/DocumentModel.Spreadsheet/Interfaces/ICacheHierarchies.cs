namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchies Class.
/// </summary>
public interface ICacheHierarchies // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hierarchy Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICacheHierarchy>? CacheHierarchies { get ; set; }
  
}
