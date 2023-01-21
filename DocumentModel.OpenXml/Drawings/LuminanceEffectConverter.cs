namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Luminance.
/// </summary>
public static class LuminanceEffectConverter
{
  /// <summary>
  /// Brightness
  /// </summary>
  private static Int32? GetBrightness(DXDraw.LuminanceEffect openXmlElement)
  {
    return openXmlElement.Brightness?.Value;
  }
  
  private static void SetBrightness(DXDraw.LuminanceEffect openXmlElement, Int32? value)
  {
    openXmlElement.Brightness = value;
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  private static Int32? GetContrast(DXDraw.LuminanceEffect openXmlElement)
  {
    return openXmlElement.Contrast?.Value;
  }
  
  private static void SetContrast(DXDraw.LuminanceEffect openXmlElement, Int32? value)
  {
    openXmlElement.Contrast = value;
  }
  
  public static DMDraws.LuminanceEffect? CreateModelElement(DXDraw.LuminanceEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LuminanceEffect();
      value.Brightness = GetBrightness(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LuminanceEffect? value)
    where OpenXmlElementType: DXDraw.LuminanceEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBrightness(openXmlElement, value?.Brightness);
      SetContrast(openXmlElement, value?.Contrast);
      return openXmlElement;
    }
    return default;
  }
}
