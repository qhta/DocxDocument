namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public static class GeoParentEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? GetGeoParentEntitiesQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoParentEntitiesQuery(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntitiesQueryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoEntity? GetGeoEntity(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoEntityConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoEntity(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoEntity? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntity? GetGeoParentEntity(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntityConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoParentEntity(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoParentEntity? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoParentEntityConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult();
      value.GeoParentEntitiesQuery = GetGeoParentEntitiesQuery(openXmlElement);
      value.GeoEntity = GetGeoEntity(openXmlElement);
      value.GeoParentEntity = GetGeoParentEntity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResult? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
