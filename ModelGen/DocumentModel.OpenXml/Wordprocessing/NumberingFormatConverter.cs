namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public static class NumberingFormatConverter
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  private static DMW.NumberFormatKind? GetVal(DXW.NumberingFormat openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.NumberingFormat openXmlElement, DMW.NumberFormatKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVal(DXW.NumberingFormat openXmlElement, DMW.NumberFormatKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(value);
  }
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetFormat(DXW.NumberingFormat openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Format);
  }
  
  private static bool CmpFormat(DXW.NumberingFormat openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Format, value, diffs, objName, "Format");
  }
  
  private static void SetFormat(DXW.NumberingFormat openXmlElement, String? value)
  {
    openXmlElement.Format = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.NumberingFormat? CreateModelElement(DXW.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingFormat();
      value.Val = GetVal(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingFormat? openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpFormat(openXmlElement, value.Format, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingFormat value)
    where OpenXmlElementType: DXW.NumberingFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingFormat openXmlElement, DMW.NumberingFormat value)
  {
    SetVal(openXmlElement, value?.Val);
    SetFormat(openXmlElement, value?.Format);
  }
}
