namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public static class LevelTextConverter
{
  /// <summary>
  /// Level Text
  /// </summary>
  private static String? GetVal(DXW.LevelText openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.LevelText openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.LevelText openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  private static Boolean? GetNull(DXW.LevelText openXmlElement)
  {
    return openXmlElement?.Null?.Value;
  }
  
  private static bool CmpNull(DXW.LevelText openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Null?.Value == value) return true;
    diffs?.Add(objName, "Null", openXmlElement?.Null?.Value, value);
    return false;
  }
  
  private static void SetNull(DXW.LevelText openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Null = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Null = null;
  }
  
  public static DMW.LevelText? CreateModelElement(DXW.LevelText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LevelText();
      value.Val = GetVal(openXmlElement);
      value.Null = GetNull(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LevelText? openXmlElement, DMW.LevelText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpNull(openXmlElement, value.Null, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LevelText? value)
    where OpenXmlElementType: DXW.LevelText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetNull(openXmlElement, value?.Null);
      return openXmlElement;
    }
    return default;
  }
}
