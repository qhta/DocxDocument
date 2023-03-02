namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQueryResults Class.
/// </summary>
public record GeoDataEntityQueryResults
{
  public Collection<GeoDataEntityQueryResult>? Items { get; set; }
}