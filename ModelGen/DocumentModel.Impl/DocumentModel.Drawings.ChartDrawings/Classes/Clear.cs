namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public partial class ClearImpl: ModelElementImpl, Clear
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ClearImpl(): base() {}
  
  public ClearImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? GeoLocationQueryResults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQueryResults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQueryResults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQueryResults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
