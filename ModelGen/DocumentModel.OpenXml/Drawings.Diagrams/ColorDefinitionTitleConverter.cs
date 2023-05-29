namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class ColorDefinitionTitleConverter
{
  /// <summary>
  /// Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.ColorDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXDrawDgms.ColorDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Language");
  }
  
  private static void SetLanguage(DXDrawDgms.ColorDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.ColorDefinitionTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDrawDgms.ColorDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXDrawDgms.ColorDefinitionTitle openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorDefinitionTitle? CreateModelElement(DXDrawDgms.ColorDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorDefinitionTitle();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ColorDefinitionTitle? openXmlElement, DMDrawsDgms.ColorDefinitionTitle? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorDefinitionTitle value)
    where OpenXmlElementType: DXDrawDgms.ColorDefinitionTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ColorDefinitionTitle openXmlElement, DMDrawsDgms.ColorDefinitionTitle value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
