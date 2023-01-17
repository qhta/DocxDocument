namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public static class GeoChildEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? GetGeoChildEntitiesQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildEntitiesQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.GeoChildEntities? GetGeoChildEntities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildEntities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoChildEntities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildEntitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult();
      value.GeoChildEntitiesQuery = GetGeoChildEntitiesQuery(openXmlElement);
      value.GeoChildEntities = GetGeoChildEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoChildEntitiesQuery(openXmlElement, value?.GeoChildEntitiesQuery);
      SetGeoChildEntities(openXmlElement, value?.GeoChildEntities);
      return openXmlElement;
    }
    return default;
  }
}
