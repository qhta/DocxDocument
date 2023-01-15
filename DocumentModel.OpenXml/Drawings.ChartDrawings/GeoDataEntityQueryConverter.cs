using DocumentModel.Drawings.ChartDrawings;
using GeoDataEntityQuery = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataEntityQuery Class.
/// </summary>
public static class GeoDataEntityQueryConverter
{
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoDataEntityQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoDataEntityQuery? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityId(GeoDataEntityQuery? openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }

  public static void SetEntityId(GeoDataEntityQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityId = new StringValue { Value = value };
      else
        openXmlElement.EntityId = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? CreateModelElement(GeoDataEntityQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataEntityQuery? value)
    where OpenXmlElementType : GeoDataEntityQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityType(openXmlElement, value?.EntityType);
      SetEntityId(openXmlElement, value?.EntityId);
      return openXmlElement;
    }
    return default;
  }
}