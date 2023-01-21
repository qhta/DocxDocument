namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label Description.
/// </summary>
public static class StyleLabelDescriptionConverter
{
  /// <summary>
  /// Natural Language
  /// </summary>
  private static String? GetLanguage(DXDrawDgms.StyleLabelDescription openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DXDrawDgms.StyleLabelDescription openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Description Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.StyleLabelDescription openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXDrawDgms.StyleLabelDescription openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMDrawsDgms.StyleLabelDescription? CreateModelElement(DXDrawDgms.StyleLabelDescription? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleLabelDescription();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleLabelDescription? value)
    where OpenXmlElementType: DXDrawDgms.StyleLabelDescription, new()
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
