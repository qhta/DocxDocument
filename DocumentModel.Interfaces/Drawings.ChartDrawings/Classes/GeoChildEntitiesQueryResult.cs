namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public class GeoChildEntitiesQueryResult: ModelElement
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