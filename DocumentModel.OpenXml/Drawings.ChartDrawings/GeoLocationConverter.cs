namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public static class GeoLocationConverter
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLatitude(DXO16DCD.GeoLocation openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  private static bool CmpLatitude(DXO16DCD.GeoLocation openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Latitude?.Value == value) return true;
    diffs?.Add(objName, "Latitude", openXmlElement?.Latitude?.Value, value);
    return false;
  }
  
  private static void SetLatitude(DXO16DCD.GeoLocation openXmlElement, Double? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLongitude(DXO16DCD.GeoLocation openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXO16DCD.GeoLocation openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXO16DCD.GeoLocation openXmlElement, Double? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO16DCD.GeoLocation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityName);
  }
  
  private static bool CmpEntityName(DXO16DCD.GeoLocation openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityName, value, diffs, objName, "EntityName");
  }
  
  private static void SetEntityName(DXO16DCD.GeoLocation openXmlElement, String? value)
  {
    openXmlElement.EntityName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoLocation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoLocation openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoLocation openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  private static DMDCDs.Address? GetAddress(DXO16DCD.GeoLocation openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Address>();
    if (element != null)
      return DMXDCDs.AddressConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAddress(DXO16DCD.GeoLocation openXmlElement, DMDCDs.Address? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.AddressConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Address>(), value, diffs, objName, propName);
  }
  
  private static void SetAddress(DXO16DCD.GeoLocation openXmlElement, DMDCDs.Address? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Address>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.AddressConverter.CreateOpenXmlElement<DXO16DCD.Address>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocation? CreateModelElement(DXO16DCD.GeoLocation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocation();
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      value.Address = GetAddress(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoLocation? openXmlElement, DMDCDs.GeoLocation? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLatitude(openXmlElement, value.Latitude, diffs, objName, propName))
        ok = false;
      if (!CmpLongitude(openXmlElement, value.Longitude, diffs, objName, propName))
        ok = false;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName, propName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName, propName))
        ok = false;
      if (!CmpAddress(openXmlElement, value.Address, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoLocation value)
    where OpenXmlElementType: DXO16DCD.GeoLocation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoLocation openXmlElement, DMDCDs.GeoLocation value)
  {
    SetLatitude(openXmlElement, value?.Latitude);
    SetLongitude(openXmlElement, value?.Longitude);
    SetEntityName(openXmlElement, value?.EntityName);
    SetEntityType(openXmlElement, value?.EntityType);
    SetAddress(openXmlElement, value?.Address);
  }
}
