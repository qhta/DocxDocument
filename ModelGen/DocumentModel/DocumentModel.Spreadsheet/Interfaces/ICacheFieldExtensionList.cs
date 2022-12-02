namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtensionList Class.
/// </summary>
public interface ICacheFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICacheFieldExtension>? CacheFieldExtensions { get ; set; }
  
}
