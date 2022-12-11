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
  
  public GeoLocationQueryResultImpl(): base() {}
  
  public GeoLocationQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  public GeoLocationQuery? GeoLocationQuery
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public GeoLocations? GeoLocations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
