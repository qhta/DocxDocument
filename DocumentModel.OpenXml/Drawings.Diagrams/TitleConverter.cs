namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public static class TitleConverter
{
  /// <summary>
  /// Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.Title openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXDrawDgms.Title openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Language");
  }
  
  private static void SetLanguage(DXDrawDgms.Title openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.Title openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDrawDgms.Title openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Normal");
  }
  
  private static void SetVal(DXDrawDgms.Title openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.Title? CreateModelElement(DXDrawDgms.Title? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Title();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Title? openXmlElement, DMDrawsDgms.Title? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Title value)
    where OpenXmlElementType: DXDrawDgms.Title, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Title openXmlElement, DMDrawsDgms.Title value)
  {
    SetLanguage(openXmlElement, value?.Language);
    SetVal(openXmlElement, value?.Val);
  }
}
