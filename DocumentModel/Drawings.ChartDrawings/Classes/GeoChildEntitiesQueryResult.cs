namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public record GeoChildEntitiesQueryResult
{
  /// <summary>
  ///   GeoChildEntitiesQuery.
  /// </summary>
  public GeoChildEntitiesQuery? GeoChildEntitiesQuery { get; set; }

  /// <summary>
  ///   GeoChildEntities.
  /// </summary>
  public GeoChildEntities? GeoChildEntities { get; set; }
}