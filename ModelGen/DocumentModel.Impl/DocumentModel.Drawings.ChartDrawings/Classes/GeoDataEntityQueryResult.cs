namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public class GeoDataEntityQueryResultImpl: ModelElementImpl, GeoDataEntityQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataEntityQueryResultImpl(): base() {}
  
  public GeoDataEntityQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? GeoDataEntityQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoData? GeoData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
