namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Address Class.
/// </summary>
public static class AddressConverter
{
  /// <summary>
  /// address1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAddress1(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.Address1?.Value;
  }
  
  private static bool CmpAddress1(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Address1?.Value == value;
  }
  
  private static void SetAddress1(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Address1 = new StringValue { Value = value };
    else
      openXmlElement.Address1 = null;
  }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCountryRegion(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.CountryRegion?.Value;
  }
  
  private static bool CmpCountryRegion(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CountryRegion?.Value == value;
  }
  
  private static void SetCountryRegion(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CountryRegion = new StringValue { Value = value };
    else
      openXmlElement.CountryRegion = null;
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict1(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.AdminDistrict1?.Value;
  }
  
  private static bool CmpAdminDistrict1(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AdminDistrict1?.Value == value;
  }
  
  private static void SetAdminDistrict1(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdminDistrict1 = new StringValue { Value = value };
    else
      openXmlElement.AdminDistrict1 = null;
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict2(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.AdminDistrict2?.Value;
  }
  
  private static bool CmpAdminDistrict2(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AdminDistrict2?.Value == value;
  }
  
  private static void SetAdminDistrict2(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AdminDistrict2 = new StringValue { Value = value };
    else
      openXmlElement.AdminDistrict2 = null;
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPostalCode(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.PostalCode?.Value;
  }
  
  private static bool CmpPostalCode(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PostalCode?.Value == value;
  }
  
  private static void SetPostalCode(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PostalCode = new StringValue { Value = value };
    else
      openXmlElement.PostalCode = null;
  }
  
  /// <summary>
  /// locality, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetLocality(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.Locality?.Value;
  }
  
  private static bool CmpLocality(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Locality?.Value == value;
  }
  
  private static void SetLocality(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Locality = new StringValue { Value = value };
    else
      openXmlElement.Locality = null;
  }
  
  /// <summary>
  /// isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetIsoCountryCode(DXO2016DrawChartDraw.Address openXmlElement)
  {
    return openXmlElement?.IsoCountryCode?.Value;
  }
  
  private static bool CmpIsoCountryCode(DXO2016DrawChartDraw.Address openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IsoCountryCode?.Value == value;
  }
  
  private static void SetIsoCountryCode(DXO2016DrawChartDraw.Address openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IsoCountryCode = new StringValue { Value = value };
    else
      openXmlElement.IsoCountryCode = null;
  }
  
  public static DMDrawsChartDraws.Address? CreateModelElement(DXO2016DrawChartDraw.Address? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Address();
      value.Address1 = GetAddress1(openXmlElement);
      value.CountryRegion = GetCountryRegion(openXmlElement);
      value.AdminDistrict1 = GetAdminDistrict1(openXmlElement);
      value.AdminDistrict2 = GetAdminDistrict2(openXmlElement);
      value.PostalCode = GetPostalCode(openXmlElement);
      value.Locality = GetLocality(openXmlElement);
      value.IsoCountryCode = GetIsoCountryCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Address? openXmlElement, DMDrawsChartDraws.Address? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAddress1(openXmlElement, value.Address1, diffs, objName))
        ok = false;
      if (!CmpCountryRegion(openXmlElement, value.CountryRegion, diffs, objName))
        ok = false;
      if (!CmpAdminDistrict1(openXmlElement, value.AdminDistrict1, diffs, objName))
        ok = false;
      if (!CmpAdminDistrict2(openXmlElement, value.AdminDistrict2, diffs, objName))
        ok = false;
      if (!CmpPostalCode(openXmlElement, value.PostalCode, diffs, objName))
        ok = false;
      if (!CmpLocality(openXmlElement, value.Locality, diffs, objName))
        ok = false;
      if (!CmpIsoCountryCode(openXmlElement, value.IsoCountryCode, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Address? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Address, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAddress1(openXmlElement, value?.Address1);
      SetCountryRegion(openXmlElement, value?.CountryRegion);
      SetAdminDistrict1(openXmlElement, value?.AdminDistrict1);
      SetAdminDistrict2(openXmlElement, value?.AdminDistrict2);
      SetPostalCode(openXmlElement, value?.PostalCode);
      SetLocality(openXmlElement, value?.Locality);
      SetIsoCountryCode(openXmlElement, value?.IsoCountryCode);
      return openXmlElement;
    }
    return default;
  }
}
