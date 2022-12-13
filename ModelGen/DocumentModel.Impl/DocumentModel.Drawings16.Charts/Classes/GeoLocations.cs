namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
public class GeoLocationsImpl: ModelElementImpl, GeoLocations
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoLocationsImpl(): base() {}
  
  public GeoLocationsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoLocation.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoLocation? GeoLocation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
