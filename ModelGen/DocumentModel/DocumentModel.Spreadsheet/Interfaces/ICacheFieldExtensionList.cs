namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtensionList Class.
/// </summary>
public interface ICacheFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICacheFieldExtension>? CacheFieldExtensions { get ; set; }
  
}
