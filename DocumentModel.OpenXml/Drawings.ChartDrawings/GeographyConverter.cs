namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public static class GeographyConverter
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.GeoProjectionType? GetProjectionType(DXO16DCD.Geography openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDCDs.GeoProjectionType>(openXmlElement?.ProjectionType?.Value);
  }
  
  private static bool CmpProjectionType(DXO16DCD.Geography openXmlElement, DMDCDs.GeoProjectionType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDCDs.GeoProjectionType>(openXmlElement?.ProjectionType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetProjectionType(DXO16DCD.Geography openXmlElement, DMDCDs.GeoProjectionType? value)
  {
    openXmlElement.ProjectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DMDCDs.GeoProjectionType>(value);
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.GeoMappingLevel? GetViewedRegionType(DXO16DCD.Geography openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDCDs.GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value);
  }
  
  private static bool CmpViewedRegionType(DXO16DCD.Geography openXmlElement, DMDCDs.GeoMappingLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDCDs.GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetViewedRegionType(DXO16DCD.Geography openXmlElement, DMDCDs.GeoMappingLevel? value)
  {
    openXmlElement.ViewedRegionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DMDCDs.GeoMappingLevel>(value);
  }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCultureLanguage(DXO16DCD.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CultureLanguage);
  }
  
  private static bool CmpCultureLanguage(DXO16DCD.Geography openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CultureLanguage, value, diffs, objName, "CultureLanguage");
  }
  
  private static void SetCultureLanguage(DXO16DCD.Geography openXmlElement, String? value)
  {
    openXmlElement.CultureLanguage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCultureRegion(DXO16DCD.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CultureRegion);
  }
  
  private static bool CmpCultureRegion(DXO16DCD.Geography openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CultureRegion, value, diffs, objName, "CultureRegion");
  }
  
  private static void SetCultureRegion(DXO16DCD.Geography openXmlElement, String? value)
  {
    openXmlElement.CultureRegion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAttribution(DXO16DCD.Geography openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Attribution);
  }
  
  private static bool CmpAttribution(DXO16DCD.Geography openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Attribution, value, diffs, objName, "Attribution");
  }
  
  private static void SetAttribution(DXO16DCD.Geography openXmlElement, String? value)
  {
    openXmlElement.Attribution = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  private static DMDCDs.GeoCache? GetGeoCache(DXO16DCD.Geography openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoCache>();
    if (element != null)
      return DMXDCDs.GeoCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoCache(DXO16DCD.Geography openXmlElement, DMDCDs.GeoCache? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoCache>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoCache(DXO16DCD.Geography openXmlElement, DMDCDs.GeoCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoCacheConverter.CreateOpenXmlElement<DXO16DCD.GeoCache>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.Geography? CreateModelElement(DXO16DCD.Geography? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.Geography();
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
  
  public static bool CompareModelElement(DXO16DCD.Geography? openXmlElement, DMDCDs.Geography? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProjectionType(openXmlElement, value.ProjectionType, diffs, objName, propName))
        ok = false;
      if (!CmpViewedRegionType(openXmlElement, value.ViewedRegionType, diffs, objName, propName))
        ok = false;
      if (!CmpCultureLanguage(openXmlElement, value.CultureLanguage, diffs, objName, propName))
        ok = false;
      if (!CmpCultureRegion(openXmlElement, value.CultureRegion, diffs, objName, propName))
        ok = false;
      if (!CmpAttribution(openXmlElement, value.Attribution, diffs, objName, propName))
        ok = false;
      if (!CmpGeoCache(openXmlElement, value.GeoCache, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Geography value)
    where OpenXmlElementType: DXO16DCD.Geography, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Geography openXmlElement, DMDCDs.Geography value)
  {
    SetProjectionType(openXmlElement, value?.ProjectionType);
    SetViewedRegionType(openXmlElement, value?.ViewedRegionType);
    SetCultureLanguage(openXmlElement, value?.CultureLanguage);
    SetCultureRegion(openXmlElement, value?.CultureRegion);
    SetAttribution(openXmlElement, value?.Attribution);
    SetGeoCache(openXmlElement, value?.GeoCache);
  }
}
