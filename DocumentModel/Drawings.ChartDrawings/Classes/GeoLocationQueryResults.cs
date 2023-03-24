namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoLocationQueryResults Class.
/// </summary>
public class GeoLocationQueryResults: ModelElement
{
  public Collection<GeoLocationQueryResult>? Items { get; set; }
}