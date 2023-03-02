namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public record GeoChildEntitiesQueryResults
{
  public Collection<GeoChildEntitiesQueryResult>? Items { get; set; }
}