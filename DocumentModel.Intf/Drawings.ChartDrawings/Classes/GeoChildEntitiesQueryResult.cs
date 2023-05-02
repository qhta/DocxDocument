namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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