namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public static class GeoParentEntityConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  public static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntity? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntity();
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoParentEntity? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
