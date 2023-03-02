namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQueryResults Class.
/// </summary>
public record GeoLocationQueryResults
{
  public Collection<GeoLocationQueryResult>? Items { get; set; }
}