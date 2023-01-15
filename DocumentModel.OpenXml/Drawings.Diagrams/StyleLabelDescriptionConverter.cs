using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Style Label Description.
/// </summary>
public static class StyleLabelDescriptionConverter
{
  /// <summary>
  ///   Natural Language
  /// </summary>
  public static String? GetLanguage(StyleLabelDescription? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(StyleLabelDescription? openXmlElement, String? value)
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
  public static String? GetVal(StyleLabelDescription? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(StyleLabelDescription? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.StyleLabelDescription? CreateModelElement(StyleLabelDescription? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleLabelDescription();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleLabelDescription? value)
    where OpenXmlElementType : StyleLabelDescription, new()
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