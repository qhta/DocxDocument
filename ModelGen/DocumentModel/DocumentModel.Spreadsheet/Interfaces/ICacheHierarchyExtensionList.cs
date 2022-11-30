namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchyExtensionList Class.
/// </summary>
public interface ICacheHierarchyExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICacheHierarchyExtension>? CacheHierarchyExtensions { get ; set; }
  
}
