namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public interface GeoDataEntityQueryResult
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataEntityQuery? GeoDataEntityQuery { get ; set; }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoData? GeoData { get ; set; }
  
}
