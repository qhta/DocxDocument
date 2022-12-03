namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtension Class.
/// </summary>
public interface CacheHierarchyExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public CacheHierarchy? CacheHierarchy { get ; set; }
  
}
