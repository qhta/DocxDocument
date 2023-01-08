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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFullDate(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, DateTime? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  public static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
