namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
public class GeoLocationsImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>, GeoLocations
{
  /// <summary>
  /// GeoLocation.
  /// </summary>
  public GeoLocation? GeoLocation
  {
    get;
    set;
  }
  
}
