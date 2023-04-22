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
    return openXmlElement?.FullDate?.Value;
  }
  
  private static bool CmpFullDate(DXW.SdtContentDate openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FullDate?.Value == value) return true;
    diffs?.Add(objName, "FullDate", openXmlElement?.FullDate?.Value, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXW.DateFormat>()?.Val?.Value;
  }
  
  private static bool CmpDateFormat(DXW.SdtContentDate openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DateFormat>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DateFormat", itemElement?.Val?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val);
  }
  
  private static bool CmpLanguageId(DXW.SdtContentDate openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val, value, diffs, objName, "LanguageId");
  }
  
  private static void SetLanguageId(DXW.SdtContentDate openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.LanguageId>(openXmlElement, value);
  }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  private static DMW.DateFormatKind? GetSdtDateMappingType(DXW.SdtContentDate openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DateFormatValues, DMW.DateFormatKind>(openXmlElement.GetFirstChild<DXW.SdtDateMappingType>()?.Val?.Value);
  }
  
  private static bool CmpSdtDateMappingType(DXW.SdtContentDate openXmlElement, DMW.DateFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DateFormatValues, DMW.DateFormatKind>(openXmlElement.GetFirstChild<DXW.SdtDateMappingType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetSdtDateMappingType(DXW.SdtContentDate openXmlElement, DMW.DateFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtDateMappingType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.DateFormatValues, DMW.DateFormatKind>(itemElement, (DMW.DateFormatKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.SdtDateMappingType, DXW.DateFormatValues, DMW.DateFormatKind>((DMW.DateFormatKind)value));
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  private static DMW.CalendarKind? GetCalendar(DXW.SdtContentDate openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.CalendarValues, DMW.CalendarKind>(openXmlElement.GetFirstChild<DXW.Calendar>()?.Val?.Value);
  }
  
  private static bool CmpCalendar(DXW.SdtContentDate openXmlElement, DMW.CalendarKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.CalendarValues, DMW.CalendarKind>(openXmlElement.GetFirstChild<DXW.Calendar>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCalendar(DXW.SdtContentDate openXmlElement, DMW.CalendarKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Calendar>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.CalendarValues, DMW.CalendarKind>(itemElement, (DMW.CalendarKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Calendar, DXW.CalendarValues, DMW.CalendarKind>((DMW.CalendarKind)value));
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
  
  public static bool CompareModelElement(DXW.SdtContentDate? openXmlElement, DMW.SdtContentDate? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFullDate(openXmlElement, value.FullDate, diffs, objName))
        ok = false;
      if (!CmpDateFormat(openXmlElement, value.DateFormat, diffs, objName))
        ok = false;
      if (!CmpLanguageId(openXmlElement, value.LanguageId, diffs, objName))
        ok = false;
      if (!CmpSdtDateMappingType(openXmlElement, value.SdtDateMappingType, diffs, objName))
        ok = false;
      if (!CmpCalendar(openXmlElement, value.Calendar, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentDate value)
    where OpenXmlElementType: DXW.SdtContentDate, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentDate openXmlElement, DMW.SdtContentDate value)
  {
    SetFullDate(openXmlElement, value?.FullDate);
    SetDateFormat(openXmlElement, value?.DateFormat);
    SetLanguageId(openXmlElement, value?.LanguageId);
    SetSdtDateMappingType(openXmlElement, value?.SdtDateMappingType);
    SetCalendar(openXmlElement, value?.Calendar);
  }
}
