namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public class GeoLocationQueryResultImpl: ModelElementImpl, GeoLocationQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations
  {
    get;
    set;
  }
  
}
