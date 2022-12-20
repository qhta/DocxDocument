namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public partial interface GeoDataPointToEntityQueryResult
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? GeoDataPointQuery { get; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery { get; set; }
  
}
