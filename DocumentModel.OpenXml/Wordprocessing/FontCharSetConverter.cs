namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public static class FontCharSetConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.FontCharSet openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.FontCharSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.FontCharSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  private static DMW.StrictCharacterSet? GetStrictCharacterSet(DXW.FontCharSet openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DMW.StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value);
  }
  
  private static bool CmpStrictCharacterSet(DXW.FontCharSet openXmlElement, DMW.StrictCharacterSet? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DMW.StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStrictCharacterSet(DXW.FontCharSet openXmlElement, DMW.StrictCharacterSet? value)
  {
    openXmlElement.StrictCharacterSet = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DMW.StrictCharacterSet>(value);
  }
  
  public static DMW.FontCharSet? CreateModelElement(DXW.FontCharSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FontCharSet();
      value.Val = GetVal(openXmlElement);
      value.StrictCharacterSet = GetStrictCharacterSet(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FontCharSet? openXmlElement, DMW.FontCharSet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpStrictCharacterSet(openXmlElement, value.StrictCharacterSet, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FontCharSet? value)
    where OpenXmlElementType: DXW.FontCharSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetStrictCharacterSet(openXmlElement, value?.StrictCharacterSet);
      return openXmlElement;
    }
    return default;
  }
}
