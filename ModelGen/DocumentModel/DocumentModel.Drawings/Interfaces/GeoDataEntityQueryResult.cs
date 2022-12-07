namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface GeoDataEntityQueryResult
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public GeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public GeoData? GeoData { get ; set; }
  
}
