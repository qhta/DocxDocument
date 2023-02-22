namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Set of Characters Which Cannot End a Line.
/// </summary>
public static class NoLineBreaksAfterKinsokuConverter
{
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXW.NoLineBreaksAfterKinsoku openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Language");
  }
  
  private static void SetLanguage(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.NoLineBreaksAfterKinsoku openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? CreateModelElement(DXW.NoLineBreaksAfterKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NoLineBreaksAfterKinsoku? openXmlElement, DMW.NoLineBreaksAfterKinsoku? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NoLineBreaksAfterKinsoku value)
    where OpenXmlElementType: DXW.NoLineBreaksAfterKinsoku, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NoLineBreaksAfterKinsoku openXmlElement, DMW.NoLineBreaksAfterKinsoku value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
    }
  }
