namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public static class GeoLocationQueryConverter
{
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCountryRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.CountryRegion?.Value;
  }
  
  public static void SetCountryRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement, String? value)
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
  public static String? GetAdminDistrict1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.AdminDistrict1?.Value;
  }
  
  public static void SetAdminDistrict1(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement, String? value)
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
  public static String? GetAdminDistrict2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.AdminDistrict2?.Value;
  }
  
  public static void SetAdminDistrict2(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement, String? value)
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
  public static String? GetPostalCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.PostalCode?.Value;
  }
  
  public static void SetPostalCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PostalCode = new StringValue { Value = value };
      else
        openXmlElement.PostalCode = null;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
