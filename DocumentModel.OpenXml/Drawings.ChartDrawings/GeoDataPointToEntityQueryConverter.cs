namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public static class GeoDataPointToEntityQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  public static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQuery? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQuery? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
