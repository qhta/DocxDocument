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
    return openXmlElement?.Language?.Value;
  }
  
  private static bool CmpLanguage(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Language?.Value == value;
  }
  
  private static void SetLanguage(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.NoLineBreaksAfterKinsoku openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.NoLineBreaksAfterKinsoku openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.NoLineBreaksAfterKinsoku? CreateModelElement(DXW.NoLineBreaksAfterKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoLineBreaksAfterKinsoku();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NoLineBreaksAfterKinsoku? value)
    where OpenXmlElementType: DXW.NoLineBreaksAfterKinsoku, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLanguage(openXmlElement, value?.Language);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
