namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public partial class GeoChildEntitiesQueryResultImpl: ModelElementImpl, GeoChildEntitiesQueryResult
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesQueryResultImpl(): base() {}
  
  public GeoChildEntitiesQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntities? GeoChildEntities
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
