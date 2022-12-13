namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public interface GeoDataPointToEntityQueryResult
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointQuery? GeoDataPointQuery { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get ; set; }
  
}
