using DocumentModel.Wordprocessing;

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
  
  private static bool CmpVal(DXW.LevelText openXmlElement, string? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Text");
  }
  
  private static void SetVal(DXW.LevelText openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  private static Boolean GetNull(DXW.LevelText openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Null) ?? false;
  }
  
  private static bool CmpNull(DXW.LevelText openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Null, value, diffs, objName, "Null");
  }
  
  private static void SetNull(DXW.LevelText openXmlElement, Boolean? value)
  {
    openXmlElement.Null = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.NumLevelText? CreateModelElement(DXW.LevelText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumLevelText();
      value.Text = GetVal(openXmlElement);
      value.IsNull = GetNull(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LevelText? openXmlElement, DMW.NumLevelText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Text, diffs, objName))
        ok = false;
      if (!CmpNull(openXmlElement, value.IsNull, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumLevelText value)
    where OpenXmlElementType: DXW.LevelText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LevelText openXmlElement, DMW.NumLevelText value)
  {
    SetVal(openXmlElement, value?.Text);
    SetNull(openXmlElement, value?.IsNull);
  }
}
