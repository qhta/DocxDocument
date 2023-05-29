namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Description.
/// </summary>
public static class DescriptionConverter
{
  /// <summary>
  /// Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.Description openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXDrawDgms.Description openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Language");
  }
  
  private static void SetLanguage(DXDrawDgms.Description openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.Description openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDrawDgms.Description openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXDrawDgms.Description openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.Description? CreateModelElement(DXDrawDgms.Description? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Description();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Description? openXmlElement, DMDrawsDgms.Description? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Description value)
    where OpenXmlElementType: DXDrawDgms.Description, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Description openXmlElement, DMDrawsDgms.Description value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
