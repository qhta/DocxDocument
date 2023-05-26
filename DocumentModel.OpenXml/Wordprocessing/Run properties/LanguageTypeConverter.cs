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
  
  private static bool CmpVal(DXW.LanguageType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
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
  
  private static bool CmpEastAsia(DXW.LanguageType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpBidi(DXW.LanguageType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Bidi, value, diffs, objName, "ComplexScript");
  }
  
  private static void SetBidi(DXW.LanguageType openXmlElement, String? value)
  {
    openXmlElement.Bidi = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Languages? CreateModelElement(DXW.LanguageType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Languages();
      value.Regular = GetVal(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.ComplexScript = GetBidi(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LanguageType? openXmlElement, DMW.Languages? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Regular, diffs, objName, propName))
        ok = false;
      if (!CmpEastAsia(openXmlElement, value.EastAsia, diffs, objName, propName))
        ok = false;
      if (!CmpBidi(openXmlElement, value.ComplexScript, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Languages value)
    where OpenXmlElementType: DXW.LanguageType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LanguageType openXmlElement, DMW.Languages value)
  {
    SetVal(openXmlElement, value?.Regular);
    SetEastAsia(openXmlElement, value?.EastAsia);
    SetBidi(openXmlElement, value?.ComplexScript);
  }
}
