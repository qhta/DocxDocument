namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtension Class.
/// </summary>
public interface ICacheHierarchyExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Excel.ICacheHierarchy? CacheHierarchy { get ; set; }
  
}
