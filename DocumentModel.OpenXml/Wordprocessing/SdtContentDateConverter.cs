namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public static class SdtContentDateConverter
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  private static DateTime? GetFullDate(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement)
  {
    return openXmlElement.FullDate?.Value;
  }
  
  private static void SetFullDate(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement, DateTime? value)
  {
    openXmlElement.FullDate = value;
  }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  private static String? GetDateFormat(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DateFormat>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDateFormat(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DateFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DateFormat { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  private static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  private static DocumentModel.Wordprocessing.DateFormatKind? GetSdtDateMappingType(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DocumentModel.Wordprocessing.DateFormatKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetSdtDateMappingType(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement, DocumentModel.Wordprocessing.DateFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType, DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DocumentModel.Wordprocessing.DateFormatKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  private static DocumentModel.Wordprocessing.CalendarKind? GetCalendar(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Calendar>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DocumentModel.Wordprocessing.CalendarKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCalendar(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement, DocumentModel.Wordprocessing.CalendarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Calendar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Calendar, DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DocumentModel.Wordprocessing.CalendarKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDate? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentDate, new()
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
