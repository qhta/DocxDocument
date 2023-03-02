namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public record GeoDataPointToEntityQueryResults
{
  public Collection<GeoDataPointToEntityQueryResult>? Items { get; set; }
}