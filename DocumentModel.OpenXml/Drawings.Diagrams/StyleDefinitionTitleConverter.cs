using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
public static class StyleDefinitionTitleConverter
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  public static String? GetLanguage(StyleDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(StyleDefinitionTitle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   Description Value
  /// </summary>
  public static String? GetVal(StyleDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(StyleDefinitionTitle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.StyleDefinitionTitle? CreateModelElement(StyleDefinitionTitle? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDefinitionTitle? value)
    where OpenXmlElementType : StyleDefinitionTitle, new()
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