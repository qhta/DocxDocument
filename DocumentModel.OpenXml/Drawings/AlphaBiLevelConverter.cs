namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public static class AlphaBiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  public static Int32? GetThreshold(DocumentFormat.OpenXml.Drawing.AlphaBiLevel? openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  public static void SetThreshold(DocumentFormat.OpenXml.Drawing.AlphaBiLevel? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Threshold = value;
  }
  
  public static DocumentModel.Drawings.AlphaBiLevel? CreateModelElement(DocumentFormat.OpenXml.Drawing.AlphaBiLevel? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AlphaBiLevel, new()
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
