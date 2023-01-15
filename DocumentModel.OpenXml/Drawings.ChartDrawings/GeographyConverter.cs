using DocumentModel.Drawings.ChartDrawings;
using Geography = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Geography Class.
/// </summary>
public static class GeographyConverter
{
  /// <summary>
  ///   projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public static GeoProjectionType? GetProjectionType(Geography? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, GeoProjectionType>(openXmlElement?.ProjectionType?.Value);
  }

  public static void SetProjectionType(Geography? openXmlElement, GeoProjectionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.ProjectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, GeoProjectionType>(value);
  }

  /// <summary>
  ///   viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public static GeoMappingLevel? GetViewedRegionType(Geography? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value);
  }

  public static void SetViewedRegionType(Geography? openXmlElement, GeoMappingLevel? value)
  {
    if (openXmlElement != null)
      openXmlElement.ViewedRegionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, GeoMappingLevel>(value);
  }

  /// <summary>
  ///   cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCultureLanguage(Geography? openXmlElement)
  {
    return openXmlElement?.CultureLanguage?.Value;
  }

  public static void SetCultureLanguage(Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CultureLanguage = new StringValue { Value = value };
      else
        openXmlElement.CultureLanguage = null;
  }

  /// <summary>
  ///   cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCultureRegion(Geography? openXmlElement)
  {
    return openXmlElement?.CultureRegion?.Value;
  }

  public static void SetCultureRegion(Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CultureRegion = new StringValue { Value = value };
      else
        openXmlElement.CultureRegion = null;
  }

  /// <summary>
  ///   attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAttribution(Geography? openXmlElement)
  {
    return openXmlElement?.Attribution?.Value;
  }

  public static void SetAttribution(Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Attribution = new StringValue { Value = value };
      else
        openXmlElement.Attribution = null;
  }

  /// <summary>
  ///   GeoCache.
  /// </summary>
  public static GeoCache? GetGeoCache(Geography? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
    if (itemElement != null)
      return GeoCacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeoCache(Geography? openXmlElement, GeoCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Geography? CreateModelElement(Geography? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Geography();
      value.ProjectionType = GetProjectionType(openXmlElement);
      value.ViewedRegionType = GetViewedRegionType(openXmlElement);
      value.CultureLanguage = GetCultureLanguage(openXmlElement);
      value.CultureRegion = GetCultureRegion(openXmlElement);
      value.Attribution = GetAttribution(openXmlElement);
      value.GeoCache = GetGeoCache(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Geography? value)
    where OpenXmlElementType : Geography, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetProjectionType(openXmlElement, value?.ProjectionType);
      SetViewedRegionType(openXmlElement, value?.ViewedRegionType);
      SetCultureLanguage(openXmlElement, value?.CultureLanguage);
      SetCultureRegion(openXmlElement, value?.CultureRegion);
      SetAttribution(openXmlElement, value?.Attribution);
      SetGeoCache(openXmlElement, value?.GeoCache);
      return openXmlElement;
    }
    return default;
  }
}