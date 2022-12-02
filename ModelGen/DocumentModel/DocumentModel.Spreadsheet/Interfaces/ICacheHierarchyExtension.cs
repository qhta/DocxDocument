namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtension Class.
/// </summary>
public interface ICacheHierarchyExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ICacheHierarchy? CacheHierarchy { get ; set; }
  
}
