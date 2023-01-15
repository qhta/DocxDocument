using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Alpha Replace Effect.
/// </summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  ///   Alpha
  /// </summary>
  public static Int32? GetAlpha(AlphaReplace? openXmlElement)
  {
    return openXmlElement?.Alpha?.Value;
  }

  public static void SetAlpha(AlphaReplace? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alpha = value;
  }

  public static DocumentModel.Drawings.AlphaReplace? CreateModelElement(AlphaReplace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaReplace();
      value.Alpha = GetAlpha(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaReplace? value)
    where OpenXmlElementType : AlphaReplace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlpha(openXmlElement, value?.Alpha);
      return openXmlElement;
    }
    return default;
  }
}