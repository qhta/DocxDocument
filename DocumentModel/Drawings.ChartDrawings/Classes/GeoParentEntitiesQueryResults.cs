namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public record GeoParentEntitiesQueryResults
{
  public Collection<GeoParentEntitiesQueryResult>? Items { get; set; }
}