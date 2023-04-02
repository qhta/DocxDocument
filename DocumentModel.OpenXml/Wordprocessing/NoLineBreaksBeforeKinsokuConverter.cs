namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public static class NoLineBreaksBeforeKinsokuConverter
{
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXW.NoLineBreaksBeforeKinsoku openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Languages");
  }
  
  private static void SetLanguage(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.NoLineBreaksBeforeKinsoku openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.NoLineBreaksBeforeKinsoku? CreateModelElement(DXW.NoLineBreaksBeforeKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoLineBreaksBeforeKinsoku();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NoLineBreaksBeforeKinsoku? openXmlElement, DMW.NoLineBreaksBeforeKinsoku? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NoLineBreaksBeforeKinsoku value)
    where OpenXmlElementType: DXW.NoLineBreaksBeforeKinsoku, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NoLineBreaksBeforeKinsoku openXmlElement, DMW.NoLineBreaksBeforeKinsoku value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
