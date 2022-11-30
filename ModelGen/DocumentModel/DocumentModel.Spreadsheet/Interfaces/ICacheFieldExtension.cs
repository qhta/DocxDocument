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
  
  public DocumentModel.Office2010.Excel.ICacheField? CacheField { get ; set; }
  
  public DocumentModel.Office2013.Excel.ICachedUniqueNames? CachedUniqueNames { get ; set; }
  
}
