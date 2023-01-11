namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public static class SdtContentDateConverter
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public static DateTime? GetFullDate(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    return openXmlElement?.FullDate?.Value;
  }
  
  public static void SetFullDate(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.FullDate = value;
  }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  public static String? GetDateFormat(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    return openXmlElement?.DateFormat?.Val?.Value;
  }
  
  public static void SetDateFormat(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DateFormat = new DocumentFormat.OpenXml.Wordprocessing.DateFormat { Val = value };
      else
        openXmlElement.DateFormat = null;
    }
  }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  public static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.DateFormatKind? GetSdtDateMappingType(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DocumentModel.Wordprocessing.DateFormatKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSdtDateMappingType(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, DocumentModel.Wordprocessing.DateFormatKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.CalendarKind? GetCalendar(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Calendar>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DocumentModel.Wordprocessing.CalendarKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCalendar(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, DocumentModel.Wordprocessing.CalendarKind? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
