namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Address Class.
/// </summary>
public static class AddressConverter
{
  /// <summary>
  /// address1, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAddress1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.Address1?.Value;
  }
  
  public static void SetAddress1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Address1 = new StringValue { Value = value };
      else
        openXmlElement.Address1 = null;
  }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCountryRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.CountryRegion?.Value;
  }
  
  public static void SetCountryRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CountryRegion = new StringValue { Value = value };
      else
        openXmlElement.CountryRegion = null;
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAdminDistrict1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.AdminDistrict1?.Value;
  }
  
  public static void SetAdminDistrict1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdminDistrict1 = new StringValue { Value = value };
      else
        openXmlElement.AdminDistrict1 = null;
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAdminDistrict2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.AdminDistrict2?.Value;
  }
  
  public static void SetAdminDistrict2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdminDistrict2 = new StringValue { Value = value };
      else
        openXmlElement.AdminDistrict2 = null;
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetPostalCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.PostalCode?.Value;
  }
  
  public static void SetPostalCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PostalCode = new StringValue { Value = value };
      else
        openXmlElement.PostalCode = null;
  }
  
  /// <summary>
  /// locality, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetLocality(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.Locality?.Value;
  }
  
  public static void SetLocality(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Locality = new StringValue { Value = value };
      else
        openXmlElement.Locality = null;
  }
  
  /// <summary>
  /// isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetIsoCountryCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    return openXmlElement?.IsoCountryCode?.Value;
  }
  
  public static void SetIsoCountryCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsoCountryCode = new StringValue { Value = value };
      else
        openXmlElement.IsoCountryCode = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Address? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Address();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Address? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address, new()
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
