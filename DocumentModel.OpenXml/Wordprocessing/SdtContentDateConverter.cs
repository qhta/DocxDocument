namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public static class SdtContentDateConverter
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  private static DateTime? GetFullDate(DXW.SdtContentDate openXmlElement)
  {
    return openXmlElement.FullDate?.Value;
  }
  
  private static void SetFullDate(DXW.SdtContentDate openXmlElement, DateTime? value)
  {
    openXmlElement.FullDate = value;
  }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  private static String? GetDateFormat(DXW.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DateFormat>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDateFormat(DXW.SdtContentDate openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DateFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DateFormat { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  private static String? GetLanguageId(DXW.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLanguageId(DXW.SdtContentDate openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  private static DMW.DateFormatKind? GetSdtDateMappingType(DXW.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtDateMappingType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DMW.DateFormatKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSdtDateMappingType(DXW.SdtContentDate openXmlElement, DMW.DateFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtDateMappingType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.SdtDateMappingType, DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DMW.DateFormatKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  private static DMW.CalendarKind? GetCalendar(DXW.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Calendar>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DMW.CalendarKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCalendar(DXW.SdtContentDate openXmlElement, DMW.CalendarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Calendar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Calendar, DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DMW.CalendarKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtContentDate? CreateModelElement(DXW.SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentDate();
      value.FullDate = GetFullDate(openXmlElement);
      value.DateFormat = GetDateFormat(openXmlElement);
      value.LanguageId = GetLanguageId(openXmlElement);
      value.SdtDateMappingType = GetSdtDateMappingType(openXmlElement);
      value.Calendar = GetCalendar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDate? value)
    where OpenXmlElementType: DXW.SdtContentDate, new()
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
