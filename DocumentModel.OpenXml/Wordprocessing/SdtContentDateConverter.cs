using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using SdtContentDate = DocumentFormat.OpenXml.Wordprocessing.SdtContentDate;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtContentDate Class.
/// </summary>
public static class SdtContentDateConverter
{
  /// <summary>
  ///   Last Known Date in XML Schema DateTime Format
  /// </summary>
  public static DateTime? GetFullDate(SdtContentDate? openXmlElement)
  {
    return openXmlElement?.FullDate?.Value;
  }

  public static void SetFullDate(SdtContentDate? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.FullDate = value;
  }

  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  public static String? GetDateFormat(SdtContentDate? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DateFormat>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDateFormat(SdtContentDate? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DateFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DateFormat { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Date Picker Language ID.
  /// </summary>
  public static String? GetLanguageId(SdtContentDate? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLanguageId(SdtContentDate? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LanguageId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LanguageId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Custom XML Data Date Storage Format.
  /// </summary>
  public static DateFormatKind? GetSdtDateMappingType(SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtDateMappingType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DateFormatValues, DateFormatKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSdtDateMappingType(SdtContentDate? openXmlElement, DateFormatKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtDateMappingType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<SdtDateMappingType, DateFormatValues, DateFormatKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Date Picker Calendar Type.
  /// </summary>
  public static CalendarKind? GetCalendar(SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Calendar>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CalendarValues, CalendarKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCalendar(SdtContentDate? openXmlElement, CalendarKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Calendar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Calendar, CalendarValues, CalendarKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtContentDate? CreateModelElement(SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDate();
      value.FullDate = GetFullDate(openXmlElement);
      value.DateFormat = GetDateFormat(openXmlElement);
      value.LanguageId = GetLanguageId(openXmlElement);
      value.SdtDateMappingType = GetSdtDateMappingType(openXmlElement);
      value.Calendar = GetCalendar(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentDate? value)
    where OpenXmlElementType : SdtContentDate, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFullDate(openXmlElement, value?.FullDate);
      SetDateFormat(openXmlElement, value?.DateFormat);
      SetLanguageId(openXmlElement, value?.LanguageId);
      SetSdtDateMappingType(openXmlElement, value?.SdtDateMappingType);
      SetCalendar(openXmlElement, value?.Calendar);
      return openXmlElement;
    }
    return default;
  }
}