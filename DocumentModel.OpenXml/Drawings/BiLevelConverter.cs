namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BiLevel Class.
/// </summary>
public static class BiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXDraw.BiLevel openXmlElement)
  {
    return openXmlElement.Threshold?.Value;
  }
  
  private static void SetThreshold(DXDraw.BiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DMDraws.BiLevel? CreateModelElement(DXDraw.BiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BiLevel? value)
    where OpenXmlElementType: DXDraw.BiLevel, new()
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
