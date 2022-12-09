namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// GeoLocation.
  /// </summary>
  public GeoLocation? GeoLocation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
