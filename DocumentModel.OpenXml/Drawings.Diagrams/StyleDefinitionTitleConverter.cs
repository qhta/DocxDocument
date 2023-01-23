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
    return openXmlElement?.Language?.Value;
  }
  
  private static bool CmpLanguage(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Language?.Value == value;
  }
  
  private static void SetLanguage(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.StyleDefinitionTitle openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXDrawDgms.StyleDefinitionTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMDrawsDgms.StyleDefinitionTitle? CreateModelElement(DXDrawDgms.StyleDefinitionTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleDefinitionTitle();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDefinitionTitle? value)
    where OpenXmlElementType: DXDrawDgms.StyleDefinitionTitle, new()
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
