namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Description.
/// </summary>
public static class ColorTransformDescriptionConverter
{
  /// <summary>
  /// Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.ColorTransformDescription openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static bool CmpLanguage(DXDrawDgms.ColorTransformDescription openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Language?.Value == value;
  }
  
  private static void SetLanguage(DXDrawDgms.ColorTransformDescription openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.ColorTransformDescription openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.ColorTransformDescription openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXDrawDgms.ColorTransformDescription openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMDrawsDgms.ColorTransformDescription? CreateModelElement(DXDrawDgms.ColorTransformDescription? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorTransformDescription();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ColorTransformDescription? openXmlElement, DMDrawsDgms.ColorTransformDescription? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorTransformDescription? value)
    where OpenXmlElementType: DXDrawDgms.ColorTransformDescription, new()
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
