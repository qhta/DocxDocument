using DocumentModel.Drawings.ChartDrawings;
using GeoDataPointQuery = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoDataPointQuery Class.
/// </summary>
public static class GeoDataPointQueryConverter
{
  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoDataPointQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoDataPointQuery? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLatitude(GeoDataPointQuery? openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }

  public static void SetLatitude(GeoDataPointQuery? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Latitude = value;
  }

  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLongitude(GeoDataPointQuery? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }

  public static void SetLongitude(GeoDataPointQuery? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Longitude = value;
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? CreateModelElement(GeoDataPointQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? value)
    where OpenXmlElementType : GeoDataPointQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityType(openXmlElement, value?.EntityType);
      SetLatitude(openXmlElement, value?.Latitude);
      SetLongitude(openXmlElement, value?.Longitude);
      return openXmlElement;
    }
    return default;
  }
}