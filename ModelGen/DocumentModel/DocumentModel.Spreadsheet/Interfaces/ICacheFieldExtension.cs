namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtension Class.
/// </summary>
public interface ICacheFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.ICacheField? CacheField { get ; set; }
  
  public DocumentModel.Spreadsheet.ICachedUniqueNames? CachedUniqueNames { get ; set; }
  
}
