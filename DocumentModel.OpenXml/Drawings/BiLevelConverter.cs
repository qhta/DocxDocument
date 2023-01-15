using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BiLevel Class.
/// </summary>
public static class BiLevelConverter
{
  /// <summary>
  ///   Threshold
  /// </summary>
  public static Int32? GetThreshold(BiLevel? openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }

  public static void SetThreshold(BiLevel? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Threshold = value;
  }

  public static DocumentModel.Drawings.BiLevel? CreateModelElement(BiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BiLevel? value)
    where OpenXmlElementType : BiLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetThreshold(openXmlElement, value?.Threshold);
      return openXmlElement;
    }
    return default;
  }
}