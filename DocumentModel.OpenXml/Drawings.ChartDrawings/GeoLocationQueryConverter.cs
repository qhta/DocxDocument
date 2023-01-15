using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EntityTypeEnum = DocumentModel.Drawings.ChartDrawings.EntityTypeEnum;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocationQuery Class.
/// </summary>
public static class GeoLocationQueryConverter
{
  /// <summary>
  ///   countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCountryRegion(GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.CountryRegion?.Value;
  }

  public static void SetCountryRegion(GeoLocationQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CountryRegion = new StringValue { Value = value };
      else
        openXmlElement.CountryRegion = null;
  }

  /// <summary>
  ///   adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAdminDistrict1(GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.AdminDistrict1?.Value;
  }

  public static void SetAdminDistrict1(GeoLocationQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdminDistrict1 = new StringValue { Value = value };
      else
        openXmlElement.AdminDistrict1 = null;
  }

  /// <summary>
  ///   adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAdminDistrict2(GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.AdminDistrict2?.Value;
  }

  public static void SetAdminDistrict2(GeoLocationQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AdminDistrict2 = new StringValue { Value = value };
      else
        openXmlElement.AdminDistrict2 = null;
  }

  /// <summary>
  ///   postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetPostalCode(GeoLocationQuery? openXmlElement)
  {
    return openXmlElement?.PostalCode?.Value;
  }

  public static void SetPostalCode(GeoLocationQuery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PostalCode = new StringValue { Value = value };
      else
        openXmlElement.PostalCode = null;
  }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoLocationQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoLocationQuery? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQuery? CreateModelElement(GeoLocationQuery? openXmlElement)
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
    where OpenXmlElementType : GeoLocationQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCountryRegion(openXmlElement, value?.CountryRegion);
      SetAdminDistrict1(openXmlElement, value?.AdminDistrict1);
      SetAdminDistrict2(openXmlElement, value?.AdminDistrict2);
      SetPostalCode(openXmlElement, value?.PostalCode);
      SetEntityType(openXmlElement, value?.EntityType);
      return openXmlElement;
    }
    return default;
  }
}