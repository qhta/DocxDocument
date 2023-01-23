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
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  private static String? GetEastAsia(DXW.LanguageType openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  private static bool CmpEastAsia(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EastAsia?.Value == value;
  }
  
  private static void SetEastAsia(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EastAsia = new StringValue { Value = value };
    else
      openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  private static String? GetBidi(DXW.LanguageType openXmlElement)
  {
    return openXmlElement?.Bidi?.Value;
  }
  
  private static bool CmpBidi(DXW.LanguageType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bidi?.Value == value;
  }
  
  private static void SetBidi(DXW.LanguageType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bidi = new StringValue { Value = value };
    else
      openXmlElement.Bidi = null;
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LanguageType? value)
    where OpenXmlElementType: DXW.LanguageType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetEastAsia(openXmlElement, value?.EastAsia);
      SetBidi(openXmlElement, value?.Bidi);
      return openXmlElement;
    }
    return default;
  }
}
