namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public static class GeographyConverter
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.GeoProjectionType? GetProjectionType(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDrawsChartDraws.GeoProjectionType>(openXmlElement?.ProjectionType?.Value);
  }
  
  private static bool CmpProjectionType(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoProjectionType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDrawsChartDraws.GeoProjectionType>(openXmlElement?.ProjectionType?.Value, value, diffs, objName);
  }
  
  private static void SetProjectionType(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoProjectionType? value)
  {
    openXmlElement.ProjectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDrawsChartDraws.GeoProjectionType>(value);
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.GeoMappingLevel? GetViewedRegionType(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDrawsChartDraws.GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value);
  }
  
  private static bool CmpViewedRegionType(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoMappingLevel? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDrawsChartDraws.GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value, value, diffs, objName);
  }
  
  private static void SetViewedRegionType(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoMappingLevel? value)
  {
    openXmlElement.ViewedRegionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDrawsChartDraws.GeoMappingLevel>(value);
  }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCultureLanguage(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CultureLanguage);
  }
  
  private static bool CmpCultureLanguage(DXO2016DrawChartDraw.Geography openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CultureLanguage, value, diffs, objName, "CultureLanguage");
  }
  
  private static void SetCultureLanguage(DXO2016DrawChartDraw.Geography openXmlElement, String? value)
  {
    openXmlElement.CultureLanguage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCultureRegion(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CultureRegion);
  }
  
  private static bool CmpCultureRegion(DXO2016DrawChartDraw.Geography openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CultureRegion, value, diffs, objName, "CultureRegion");
  }
  
  private static void SetCultureRegion(DXO2016DrawChartDraw.Geography openXmlElement, String? value)
  {
    openXmlElement.CultureRegion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAttribution(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Attribution);
  }
  
  private static bool CmpAttribution(DXO2016DrawChartDraw.Geography openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Attribution, value, diffs, objName, "Attribution");
  }
  
  private static void SetAttribution(DXO2016DrawChartDraw.Geography openXmlElement, String? value)
  {
    openXmlElement.Attribution = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  private static DMDrawsChartDraws.GeoCache? GetGeoCache(DXO2016DrawChartDraw.Geography openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoCache>();
    if (element != null)
      return DMXDrawsChartDraws.GeoCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoCache(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoCache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoCache>(), value, diffs, objName);
  }
  
  private static void SetGeoCache(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.GeoCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoCacheConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Geography? CreateModelElement(DXO2016DrawChartDraw.Geography? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Geography? openXmlElement, DMDrawsChartDraws.Geography? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProjectionType(openXmlElement, value.ProjectionType, diffs, objName))
        ok = false;
      if (!CmpViewedRegionType(openXmlElement, value.ViewedRegionType, diffs, objName))
        ok = false;
      if (!CmpCultureLanguage(openXmlElement, value.CultureLanguage, diffs, objName))
        ok = false;
      if (!CmpCultureRegion(openXmlElement, value.CultureRegion, diffs, objName))
        ok = false;
      if (!CmpAttribution(openXmlElement, value.Attribution, diffs, objName))
        ok = false;
      if (!CmpGeoCache(openXmlElement, value.GeoCache, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Geography value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Geography, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Geography openXmlElement, DMDrawsChartDraws.Geography value)
  {
    SetProjectionType(openXmlElement, value?.ProjectionType);
    SetViewedRegionType(openXmlElement, value?.ViewedRegionType);
    SetCultureLanguage(openXmlElement, value?.CultureLanguage);
    SetCultureRegion(openXmlElement, value?.CultureRegion);
    SetAttribution(openXmlElement, value?.Attribution);
    SetGeoCache(openXmlElement, value?.GeoCache);
  }
}
