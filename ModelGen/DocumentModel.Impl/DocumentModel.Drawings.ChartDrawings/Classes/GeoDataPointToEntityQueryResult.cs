namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public class GeoDataPointToEntityQueryResultImpl: ModelElementImpl, GeoDataPointToEntityQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataPointToEntityQueryResultImpl(): base() {}
  
  public GeoDataPointToEntityQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? GeoDataPointQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataPointQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataPointQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
