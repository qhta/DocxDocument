namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public class GeoLocationImpl: ModelElementImpl, GeoLocation
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoLocationImpl(): base() {}
  
  public GeoLocationImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Latitude
  {
    get => (System.Double?)OpenXmlElement?.Latitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Latitude = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Longitude
  {
    get => (System.Double?)OpenXmlElement?.Longitude?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Longitude = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName
  {
    get => (System.String?)OpenXmlElement?.EntityName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType
  {
    get => (DocumentModel.Drawings.ChartDrawings.EntityTypeEnum?)OpenXmlElement?.EntityType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum?)value;
    }
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Address? Address
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.AddressImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.AddressImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
