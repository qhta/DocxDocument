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
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.FontCharSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Normal");
  }
  
  private static void SetVal(DXW.FontCharSet openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.StrictCharacterSet, DMW.StrictCharacterSet>(openXmlElement?.StrictCharacterSet?.Value, value, diffs, objName);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FontCharSet value)
    where OpenXmlElementType: DXW.FontCharSet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FontCharSet openXmlElement, DMW.FontCharSet value)
  {
    SetVal(openXmlElement, value?.Val);
    SetStrictCharacterSet(openXmlElement, value?.StrictCharacterSet);
  }
}
