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
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.LevelText openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.LevelText openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  private static Boolean? GetNull(DXW.LevelText openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Null);
  }
  
  private static bool CmpNull(DXW.LevelText openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Null, value, diffs, objName, "Null");
  }
  
  private static void SetNull(DXW.LevelText openXmlElement, Boolean? value)
  {
    openXmlElement.Null = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DocumentModel.Wordprocessing.LevelText? CreateModelElement(DXW.LevelText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LevelText();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LevelText value)
    where OpenXmlElementType: DXW.LevelText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LevelText openXmlElement, DMW.LevelText value)
  {
    SetVal(openXmlElement, value?.Val);
    SetNull(openXmlElement, value?.Null);
  }
}
