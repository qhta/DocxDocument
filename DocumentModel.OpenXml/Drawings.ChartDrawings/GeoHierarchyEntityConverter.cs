using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EntityTypeEnum = DocumentModel.Drawings.ChartDrawings.EntityTypeEnum;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoHierarchyEntity Class.
/// </summary>
public static class GeoHierarchyEntityConverter
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(GeoHierarchyEntity? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }

  public static void SetEntityName(GeoHierarchyEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(GeoHierarchyEntity? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }

  public static void SetEntityId(GeoHierarchyEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoHierarchyEntity? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoHierarchyEntity? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity? CreateModelElement(GeoHierarchyEntity? openXmlElement)
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
    where OpenXmlElementType : GeoHierarchyEntity, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityId(openXmlElement, value?.EntityId);
      SetEntityType(openXmlElement, value?.EntityType);
      return openXmlElement;
    }
    return default;
  }
}