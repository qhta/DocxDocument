namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtensionList Class.
/// </summary>
public interface ICacheSourceExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICacheSourceExtension>? CacheSourceExtensions { get ; set; }
  
}
