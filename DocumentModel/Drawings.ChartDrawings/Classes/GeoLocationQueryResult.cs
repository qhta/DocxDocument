namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoLocationQueryResult Class.
/// </summary>
public class GeoLocationQueryResult: ModelElement
{
  /// <summary>
  ///   GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery { get; set; }

  /// <summary>
  ///   GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations { get; set; }
}