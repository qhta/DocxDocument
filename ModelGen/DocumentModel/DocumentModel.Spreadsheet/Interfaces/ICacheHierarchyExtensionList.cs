namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtensionList Class.
/// </summary>
public interface ICacheHierarchyExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICacheHierarchyExtension>? CacheHierarchyExtensions { get ; set; }
  
}
