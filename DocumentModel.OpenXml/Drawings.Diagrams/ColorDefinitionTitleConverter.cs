using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
public static class ColorDefinitionTitleConverter
{
  /// <summary>
  ///   Language
  /// </summary>
  public static String? GetLanguage(ColorDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(ColorDefinitionTitle? openXmlElement, String? value)
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
  public static String? GetVal(ColorDefinitionTitle? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(ColorDefinitionTitle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.ColorDefinitionTitle? CreateModelElement(ColorDefinitionTitle? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorDefinitionTitle? value)
    where OpenXmlElementType : ColorDefinitionTitle, new()
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