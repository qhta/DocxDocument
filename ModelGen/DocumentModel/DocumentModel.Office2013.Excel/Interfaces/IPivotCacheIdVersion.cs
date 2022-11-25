namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotCacheIdVersion Class.
/// </summary>
public interface IPivotCacheIdVersion // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// cacheIdSupportedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Byte? CacheIdSupportedVersion { get ; set; }
  
  /// <summary>
  /// cacheIdCreatedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Byte? CacheIdCreatedVersion { get ; set; }
  
}
