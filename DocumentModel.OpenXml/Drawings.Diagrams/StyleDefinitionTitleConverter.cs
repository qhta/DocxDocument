namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class StyleDefinitionTitleConverter
{
  /// <summary>
  /// Natural Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.StyleDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Languages");
  }
  
  private static void SetLanguage(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.StyleDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Normal");
  }
  
  private static void SetVal(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDefinitionTitle? CreateModelElement(DXDrawDgms.StyleDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDefinitionTitle();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.StyleDefinitionTitle? openXmlElement, DMDrawsDgms.StyleDefinitionTitle? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDefinitionTitle value)
    where OpenXmlElementType: DXDrawDgms.StyleDefinitionTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.StyleDefinitionTitle openXmlElement, DMDrawsDgms.StyleDefinitionTitle value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
