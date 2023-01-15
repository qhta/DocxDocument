using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Description.
/// </summary>
public static class DescriptionConverter
{
  /// <summary>
  ///   Language
  /// </summary>
  public static String? GetLanguage(Description? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(Description? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static String? GetVal(Description? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Description? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Drawings.Diagrams.Description? CreateModelElement(Description? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Description? value)
    where OpenXmlElementType : Description, new()
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