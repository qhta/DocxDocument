namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheIdVersion Class.
/// </summary>
public interface IPivotCacheIdVersion // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// cacheIdSupportedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? CacheIdSupportedVersion { get ; set; }
  
  /// <summary>
  /// cacheIdCreatedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? CacheIdCreatedVersion { get ; set; }
  
}
