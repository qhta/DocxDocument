namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public static class AlphaBiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXDraw.AlphaBiLevel openXmlElement)
  {
    return openXmlElement.Threshold?.Value;
  }
  
  private static void SetThreshold(DXDraw.AlphaBiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DMDraws.AlphaBiLevel? CreateModelElement(DXDraw.AlphaBiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AlphaBiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaBiLevel? value)
    where OpenXmlElementType: DXDraw.AlphaBiLevel, new()
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
