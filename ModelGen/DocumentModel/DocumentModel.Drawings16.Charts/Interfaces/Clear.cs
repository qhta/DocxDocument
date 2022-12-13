namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public interface Clear
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoLocationQueryResults? GeoLocationQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataEntityQueryResults? GeoDataEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get ; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get ; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get ; set; }
  
}
