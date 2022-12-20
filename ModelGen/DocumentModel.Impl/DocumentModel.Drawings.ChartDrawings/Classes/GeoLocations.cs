namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
public partial class GeoLocationsImpl: ModelElementImpl, GeoLocations
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
  public DocumentModel.Drawings.ChartDrawings.GeoLocation? GeoLocation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoLocationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoLocationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
