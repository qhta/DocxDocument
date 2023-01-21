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
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DXDrawDgms.Description openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.Description openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXDrawDgms.Description openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMDrawsDgms.Description? CreateModelElement(DXDrawDgms.Description? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Description();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Description? value)
    where OpenXmlElementType: DXDrawDgms.Description, new()
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
