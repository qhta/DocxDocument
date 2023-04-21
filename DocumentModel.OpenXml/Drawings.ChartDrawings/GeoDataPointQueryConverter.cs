namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public static class GeoDataPointQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoDataPointQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoDataPointQuery openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoDataPointQuery openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLatitude(DXO16DCD.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  private static bool CmpLatitude(DXO16DCD.GeoDataPointQuery openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Latitude?.Value == value) return true;
    diffs?.Add(objName, "Latitude", openXmlElement?.Latitude?.Value, value);
    return false;
  }
  
  private static void SetLatitude(DXO16DCD.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLongitude(DXO16DCD.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXO16DCD.GeoDataPointQuery openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXO16DCD.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Longitude = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? CreateModelElement(DXO16DCD.GeoDataPointQuery? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.GeoDataPointQuery? openXmlElement, DMDCDs.GeoDataPointQuery? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName))
        ok = false;
      if (!CmpLatitude(openXmlElement, value.Latitude, diffs, objName))
        ok = false;
      if (!CmpLongitude(openXmlElement, value.Longitude, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataPointQuery value)
    where OpenXmlElementType: DXO16DCD.GeoDataPointQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataPointQuery openXmlElement, DMDCDs.GeoDataPointQuery value)
  {
    SetEntityType(openXmlElement, value?.EntityType);
    SetLatitude(openXmlElement, value?.Latitude);
    SetLongitude(openXmlElement, value?.Longitude);
  }
}
