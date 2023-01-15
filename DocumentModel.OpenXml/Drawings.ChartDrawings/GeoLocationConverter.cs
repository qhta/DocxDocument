using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Address = DocumentModel.Drawings.ChartDrawings.Address;
using EntityTypeEnum = DocumentModel.Drawings.ChartDrawings.EntityTypeEnum;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoLocation Class.
/// </summary>
public static class GeoLocationConverter
{
  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLatitude(GeoLocation? openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }

  public static void SetLatitude(GeoLocation? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Latitude = value;
  }

  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLongitude(GeoLocation? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }

  public static void SetLongitude(GeoLocation? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Longitude = value;
  }

  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(GeoLocation? openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }

  public static void SetEntityName(GeoLocation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EntityName = new StringValue { Value = value };
      else
        openXmlElement.EntityName = null;
  }

  /// <summary>
  ///   entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static EntityTypeEnum? GetEntityType(GeoLocation? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }

  public static void SetEntityType(GeoLocation? openXmlElement, EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, EntityTypeEnum>(value);
  }

  /// <summary>
  ///   Address.
  /// </summary>
  public static Address? GetAddress(GeoLocation? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address>();
    if (itemElement != null)
      return AddressConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAddress(GeoLocation? openXmlElement, Address? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AddressConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.GeoLocation? CreateModelElement(GeoLocation? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoLocation? value)
    where OpenXmlElementType : GeoLocation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatitude(openXmlElement, value?.Latitude);
      SetLongitude(openXmlElement, value?.Longitude);
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityType(openXmlElement, value?.EntityType);
      SetAddress(openXmlElement, value?.Address);
      return openXmlElement;
    }
    return default;
  }
}