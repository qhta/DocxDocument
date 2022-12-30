namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public partial class Clear
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? GeoLocationQueryResults { get; set; }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? GeoDataEntityQueryResults { get; set; }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get; set; }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get; set; }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get; set; }
  
}
