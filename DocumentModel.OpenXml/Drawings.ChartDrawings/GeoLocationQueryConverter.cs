namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public static class GeoLocationQueryConverter
{
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCountryRegion(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CountryRegion);
  }
  
  private static bool CmpCountryRegion(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CountryRegion, value, diffs, objName, "CountryRegion");
  }
  
  private static void SetCountryRegion(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.CountryRegion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict1(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict1);
  }
  
  private static bool CmpAdminDistrict1(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict1, value, diffs, objName, "AdminDistrict1");
  }
  
  private static void SetAdminDistrict1(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict2(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict2);
  }
  
  private static bool CmpAdminDistrict2(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict2, value, diffs, objName, "AdminDistrict2");
  }
  
  private static void SetAdminDistrict2(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPostalCode(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PostalCode);
  }
  
  private static bool CmpPostalCode(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PostalCode, value, diffs, objName, "PostalCode");
  }
  
  private static void SetPostalCode(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, String? value)
  {
    openXmlElement.PostalCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.EntityTypeEnum? GetEntityType(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEntityType(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? CreateModelElement(DXO2016DrawChartDraw.GeoLocationQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQuery();
      value.CountryRegion = GetCountryRegion(openXmlElement);
      value.AdminDistrict1 = GetAdminDistrict1(openXmlElement);
      value.AdminDistrict2 = GetAdminDistrict2(openXmlElement);
      value.PostalCode = GetPostalCode(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocationQuery? openXmlElement, DMDrawsChartDraws.GeoLocationQuery? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCountryRegion(openXmlElement, value.CountryRegion, diffs, objName))
        ok = false;
      if (!CmpAdminDistrict1(openXmlElement, value.AdminDistrict1, diffs, objName))
        ok = false;
      if (!CmpAdminDistrict2(openXmlElement, value.AdminDistrict2, diffs, objName))
        ok = false;
      if (!CmpPostalCode(openXmlElement, value.PostalCode, diffs, objName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocationQuery value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocationQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoLocationQuery openXmlElement, DMDrawsChartDraws.GeoLocationQuery value)
  {
    SetCountryRegion(openXmlElement, value?.CountryRegion);
    SetAdminDistrict1(openXmlElement, value?.AdminDistrict1);
    SetAdminDistrict2(openXmlElement, value?.AdminDistrict2);
    SetPostalCode(openXmlElement, value?.PostalCode);
    SetEntityType(openXmlElement, value?.EntityType);
    }
  }
