namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtension Class.
/// </summary>
public interface ICacheFieldExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ICacheField? CacheField { get ; set; }
  
  public ICachedUniqueNames? CachedUniqueNames { get ; set; }
  
}
