namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Address Class.
/// </summary>
public static class AddressConverter
{
  /// <summary>
  /// address1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAddress1(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Address1);
  }
  
  private static bool CmpAddress1(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Address1, value, diffs, objName, "Address1");
  }
  
  private static void SetAddress1(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.Address1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetCountryRegion(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CountryRegion);
  }
  
  private static bool CmpCountryRegion(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CountryRegion, value, diffs, objName, "CountryRegion");
  }
  
  private static void SetCountryRegion(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.CountryRegion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict1(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict1);
  }
  
  private static bool CmpAdminDistrict1(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict1, value, diffs, objName, "AdminDistrict1");
  }
  
  private static void SetAdminDistrict1(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict1 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetAdminDistrict2(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AdminDistrict2);
  }
  
  private static bool CmpAdminDistrict2(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AdminDistrict2, value, diffs, objName, "AdminDistrict2");
  }
  
  private static void SetAdminDistrict2(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.AdminDistrict2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPostalCode(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PostalCode);
  }
  
  private static bool CmpPostalCode(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PostalCode, value, diffs, objName, "PostalCode");
  }
  
  private static void SetPostalCode(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.PostalCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// locality, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetLocality(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Locality);
  }
  
  private static bool CmpLocality(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Locality, value, diffs, objName, "Locality");
  }
  
  private static void SetLocality(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.Locality = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetIsoCountryCode(DXO16DCD.Address openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IsoCountryCode);
  }
  
  private static bool CmpIsoCountryCode(DXO16DCD.Address openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IsoCountryCode, value, diffs, objName, "IsoCountryCode");
  }
  
  private static void SetIsoCountryCode(DXO16DCD.Address openXmlElement, String? value)
  {
    openXmlElement.IsoCountryCode = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDCDs.Address? CreateModelElement(DXO16DCD.Address? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.Address();
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
  
  public static bool CompareModelElement(DXO16DCD.Address? openXmlElement, DMDCDs.Address? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAddress1(openXmlElement, value.Address1, diffs, objName, propName))
        ok = false;
      if (!CmpCountryRegion(openXmlElement, value.CountryRegion, diffs, objName, propName))
        ok = false;
      if (!CmpAdminDistrict1(openXmlElement, value.AdminDistrict1, diffs, objName, propName))
        ok = false;
      if (!CmpAdminDistrict2(openXmlElement, value.AdminDistrict2, diffs, objName, propName))
        ok = false;
      if (!CmpPostalCode(openXmlElement, value.PostalCode, diffs, objName, propName))
        ok = false;
      if (!CmpLocality(openXmlElement, value.Locality, diffs, objName, propName))
        ok = false;
      if (!CmpIsoCountryCode(openXmlElement, value.IsoCountryCode, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Address value)
    where OpenXmlElementType: DXO16DCD.Address, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Address openXmlElement, DMDCDs.Address value)
  {
    SetAddress1(openXmlElement, value?.Address1);
    SetCountryRegion(openXmlElement, value?.CountryRegion);
    SetAdminDistrict1(openXmlElement, value?.AdminDistrict1);
    SetAdminDistrict2(openXmlElement, value?.AdminDistrict2);
    SetPostalCode(openXmlElement, value?.PostalCode);
    SetLocality(openXmlElement, value?.Locality);
    SetIsoCountryCode(openXmlElement, value?.IsoCountryCode);
  }
}
