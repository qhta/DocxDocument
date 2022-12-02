namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSourceExtensionList Class.
/// </summary>
public interface ICacheSourceExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICacheSourceExtension>? CacheSourceExtensions { get ; set; }
  
}
