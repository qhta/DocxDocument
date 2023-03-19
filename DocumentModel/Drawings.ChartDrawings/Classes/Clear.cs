namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Clear Class.
/// </summary>
public class Clear: ModelElement
{
  /// <summary>
  ///   GeoLocationQueryResults.
  /// </summary>
  public GeoLocationQueryResults? GeoLocationQueryResults { get; set; }

  /// <summary>
  ///   GeoDataEntityQueryResults.
  /// </summary>
  public GeoDataEntityQueryResults? GeoDataEntityQueryResults { get; set; }

  /// <summary>
  ///   GeoDataPointToEntityQueryResults.
  /// </summary>
  public GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults { get; set; }

  /// <summary>
  ///   GeoChildEntitiesQueryResults.
  /// </summary>
  public GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults { get; set; }

  /// <summary>
  ///   GeoParentEntitiesQueryResults.
  /// </summary>
  public GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults { get; set; }
}