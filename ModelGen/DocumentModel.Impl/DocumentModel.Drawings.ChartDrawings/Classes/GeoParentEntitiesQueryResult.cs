namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public partial class GeoParentEntitiesQueryResultImpl: ModelElementImpl, GeoParentEntitiesQueryResult
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GeoParentEntitiesQueryResultImpl(): base() {}
  
  public GeoParentEntitiesQueryResultImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoEntity? GeoEntity
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoEntityImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoEntityImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntity? GeoParentEntity
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoParentEntityImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoParentEntityImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
