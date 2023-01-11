namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  public static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoChildTypes? GetGeoChildTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildTypesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoChildTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoChildTypes? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildTypesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      value.GeoChildTypes = GetGeoChildTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
