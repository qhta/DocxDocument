namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotCacheIdVersion Class.
/// </summary>
public class PivotCacheIdVersion: IPivotCacheIdVersion
{
  /// <summary>
  /// cacheIdSupportedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public byte? CacheIdSupportedVersion
  {
    get;
    set;
  }
  
  /// <summary>
  /// cacheIdCreatedVersion, this property is only available in Office 2013 and later.
  /// </summary>
  public byte? CacheIdCreatedVersion
  {
    get;
    set;
  }
  
}
