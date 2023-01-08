namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public static class SdtContentDateConverter
{
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
