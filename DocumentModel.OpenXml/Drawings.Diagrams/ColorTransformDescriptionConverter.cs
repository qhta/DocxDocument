using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Description.
/// </summary>
public static class ColorTransformDescriptionConverter
{
  /// <summary>
  ///   Language
  /// </summary>
  public static String? GetLanguage(ColorTransformDescription? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(ColorTransformDescription? openXmlElement, String? value)
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
  public static String? GetVal(ColorTransformDescription? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(ColorTransformDescription? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.ColorTransformDescription? CreateModelElement(ColorTransformDescription? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformDescription();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformDescription? value)
    where OpenXmlElementType : ColorTransformDescription, new()
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