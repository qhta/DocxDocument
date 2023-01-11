namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public static class GeoHierarchyEntityConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  public static void SetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  public static void SetEntityId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
