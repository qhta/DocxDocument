namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class StyleDefinitionTitleConverter
{
  /// <summary>
  /// Natural Language
  /// </summary>
  private static String? GetLanguage(DXDD.StyleDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXDD.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Languages");
  }
  
  private static void SetLanguage(DXDD.StyleDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDD.StyleDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDD.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXDD.StyleDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDD.StyleDefinitionTitle? CreateModelElement(DXDD.StyleDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.StyleDefinitionTitle();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.StyleDefinitionTitle? openXmlElement, DMDD.StyleDefinitionTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName, propName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.StyleDefinitionTitle value)
    where OpenXmlElementType: DXDD.StyleDefinitionTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.StyleDefinitionTitle openXmlElement, DMDD.StyleDefinitionTitle value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
