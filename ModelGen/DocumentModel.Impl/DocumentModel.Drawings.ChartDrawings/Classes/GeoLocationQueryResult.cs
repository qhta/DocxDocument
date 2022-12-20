namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public partial class GeoLocationQueryResultImpl: ModelElementImpl, GeoLocationQueryResult
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
  public DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? GeoLocationQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoLocationQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoLocations? GeoLocations
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoLocationsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocations>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoLocationsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
