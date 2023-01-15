using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EntityTypeEnum = DocumentModel.Drawings.ChartDrawings.EntityTypeEnum;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoEntity Class.
/// </summary>
public static class GeoEntityConverter
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(GeoEntity? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }

  public static void SetEntityName(GeoEntity? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoEntity? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoEntity? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoEntity? CreateModelElement(GeoEntity? openXmlElement)
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
    where OpenXmlElementType : GeoEntity, new()
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