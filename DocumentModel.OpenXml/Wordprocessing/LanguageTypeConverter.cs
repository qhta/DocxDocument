namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public static class LanguageTypeConverter
{
  /// <summary>
  /// Latin Language
  /// </summary>
  private static String? GetVal(DXW.LanguageType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.LanguageType openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  private static String? GetEastAsia(DXW.LanguageType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EastAsia);
  }
  
  private static bool CmpEastAsia(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EastAsia, value, diffs, objName, "EastAsia");
  }
  
  private static void SetEastAsia(DXW.LanguageType openXmlElement, String? value)
  {
    openXmlElement.EastAsia = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  private static String? GetBidi(DXW.LanguageType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Bidi);
  }
  
  private static bool CmpBidi(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Bidi, value, diffs, objName, "Bidi");
  }
  
  private static void SetBidi(DXW.LanguageType openXmlElement, String? value)
  {
    openXmlElement.Bidi = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.LanguageType? CreateModelElement(DXW.LanguageType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LanguageType();
      value.Val = GetVal(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.Bidi = GetBidi(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LanguageType? openXmlElement, DMW.LanguageType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpEastAsia(openXmlElement, value.EastAsia, diffs, objName))
        ok = false;
      if (!CmpBidi(openXmlElement, value.Bidi, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LanguageType value)
    where OpenXmlElementType: DXW.LanguageType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LanguageType openXmlElement, DMW.LanguageType value)
  {
    SetVal(openXmlElement, value?.Val);
    SetEastAsia(openXmlElement, value?.EastAsia);
    SetBidi(openXmlElement, value?.Bidi);
  }
}
