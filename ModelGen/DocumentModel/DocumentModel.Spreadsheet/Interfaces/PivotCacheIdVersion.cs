namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheIdVersion Class.
/// </summary>
public interface PivotCacheIdVersion // : System.Boolean
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
