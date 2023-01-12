namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public static class GeoEntityConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  public static void SetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoEntity? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoEntity();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoEntity? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityType(openXmlElement, value?.EntityType);
      return openXmlElement;
    }
    return default;
  }
}
