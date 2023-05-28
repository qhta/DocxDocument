namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public static class GeoLocationQueryConverter
{
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCountryRegion(DXO16DCD.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CountryRegion);
  }
  
  private static bool CmpCountryRegion(DXO16DCD.GeoLocationQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CountryRegion, value, diffs, objName, "CountryRegion");
  }
  
  private static void SetCountryRegion(DXO16DCD.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.CountryRegion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict1(DXO16DCD.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict1);
  }
  
  private static bool CmpAdminDistrict1(DXO16DCD.GeoLocationQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict1, value, diffs, objName, "AdminDistrict1");
  }
  
  private static void SetAdminDistrict1(DXO16DCD.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict2(DXO16DCD.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict2);
  }
  
  private static bool CmpAdminDistrict2(DXO16DCD.GeoLocationQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict2, value, diffs, objName, "AdminDistrict2");
  }
  
  private static void SetAdminDistrict2(DXO16DCD.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPostalCode(DXO16DCD.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PostalCode);
  }
  
  private static bool CmpPostalCode(DXO16DCD.GeoLocationQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PostalCode, value, diffs, objName, "PostalCode");
  }
  
  private static void SetPostalCode(DXO16DCD.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.PostalCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoLocationQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoLocationQuery openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoLocationQuery openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  public static DMDCDs.GeoLocationQuery? CreateModelElement(DXO16DCD.GeoLocationQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoLocationQuery();
      value.CountryRegion = GetCountryRegion(openXmlElement);
      value.AdminDistrict1 = GetAdminDistrict1(openXmlElement);
      value.AdminDistrict2 = GetAdminDistrict2(openXmlElement);
      value.PostalCode = GetPostalCode(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoLocationQuery? openXmlElement, DMDCDs.GeoLocationQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCountryRegion(openXmlElement, value.CountryRegion, diffs, objName, propName))
        ok = false;
      if (!CmpAdminDistrict1(openXmlElement, value.AdminDistrict1, diffs, objName, propName))
        ok = false;
      if (!CmpAdminDistrict2(openXmlElement, value.AdminDistrict2, diffs, objName, propName))
        ok = false;
      if (!CmpPostalCode(openXmlElement, value.PostalCode, diffs, objName, propName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoLocationQuery value)
    where OpenXmlElementType: DXO16DCD.GeoLocationQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoLocationQuery openXmlElement, DMDCDs.GeoLocationQuery value)
  {
    SetCountryRegion(openXmlElement, value?.CountryRegion);
    SetAdminDistrict1(openXmlElement, value?.AdminDistrict1);
    SetAdminDistrict2(openXmlElement, value?.AdminDistrict2);
    SetPostalCode(openXmlElement, value?.PostalCode);
    SetEntityType(openXmlElement, value?.EntityType);
  }
}
