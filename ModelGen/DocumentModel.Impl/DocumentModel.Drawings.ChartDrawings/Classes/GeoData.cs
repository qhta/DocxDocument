namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public partial class GeoDataImpl: ModelElementImpl, GeoData
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
    get => (System.String?)OpenXmlElement?.EntityName?.Value;
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
    get => (System.String?)OpenXmlElement?.EntityId?.Value;
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
    get => (System.Double?)OpenXmlElement?.East?.Value;
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
    get => (System.Double?)OpenXmlElement?.West?.Value;
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
    get => (System.Double?)OpenXmlElement?.North?.Value;
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
    get => (System.Double?)OpenXmlElement?.South?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.South = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoPolygons? GeoPolygons
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoPolygonsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoPolygonsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Copyrights? Copyrights
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.CopyrightsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.CopyrightsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
