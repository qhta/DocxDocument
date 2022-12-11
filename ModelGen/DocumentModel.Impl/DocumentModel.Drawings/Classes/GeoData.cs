namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public class GeoDataImpl: ModelElementImpl, GeoData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataImpl(): base() {}
  
  public GeoDataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName
  {
    get => (String?)OpenXmlElement?.EntityName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId
  {
    get => (String?)OpenXmlElement?.EntityId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? East
  {
    get => (Double?)OpenXmlElement?.East?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.East = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? West
  {
    get => (Double?)OpenXmlElement?.West?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.West = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? North
  {
    get => (Double?)OpenXmlElement?.North?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.North = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? South
  {
    get => (Double?)OpenXmlElement?.South?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.South = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public GeoPolygons? GeoPolygons
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public Copyrights? Copyrights
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
