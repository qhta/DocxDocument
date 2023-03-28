namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Footnote Numbering Format converter from/to OpenXml.
///</summary>
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Val?.Value, value, diffs, objName);
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
    return StringValueConverter.CmpValue(openXmlElement?.Format, value, diffs, objName, "Custom");
  }
  
  private static void SetFormat(DXW.NumberingFormat openXmlElement, String? value)
  {
    openXmlElement.Format = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.NumberingFormat? CreateModelElement(DXW.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingFormat();
      value.Type = GetVal(openXmlElement);
      value.Custom = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingFormat? openXmlElement, DMW.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpFormat(openXmlElement, value.Custom, diffs, objName))
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
    SetVal(openXmlElement, value?.Type);
    SetFormat(openXmlElement, value?.Custom);
  }
}
