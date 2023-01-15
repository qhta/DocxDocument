using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the AlphaBiLevel Class.
/// </summary>
public static class AlphaBiLevelConverter
{
  /// <summary>
  ///   Threshold
  /// </summary>
  public static Int32? GetThreshold(AlphaBiLevel? openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }

  public static void SetThreshold(AlphaBiLevel? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Threshold = value;
  }

  public static DocumentModel.Drawings.AlphaBiLevel? CreateModelElement(AlphaBiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaBiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaBiLevel? value)
    where OpenXmlElementType : AlphaBiLevel, new()
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