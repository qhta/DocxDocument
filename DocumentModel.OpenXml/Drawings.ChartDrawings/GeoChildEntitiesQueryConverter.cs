namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.GeoChildTypes? GetGeoChildTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoChildTypesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoChildTypes? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      SetGeoChildTypes(openXmlElement, value?.GeoChildTypes);
      return openXmlElement;
    }
    return default;
  }
}
