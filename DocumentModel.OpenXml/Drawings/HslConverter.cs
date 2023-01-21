namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public static class HslConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement.Hue?.Value;
  }
  
  private static void SetHue(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  private static Int32? GetSaturation(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement.Saturation?.Value;
  }
  
  private static void SetSaturation(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Saturation = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  private static Int32? GetLuminance(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement.Luminance?.Value;
  }
  
  private static void SetLuminance(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Luminance = value;
  }
  
  public static DMDraws.Hsl? CreateModelElement(DXDraw.Hsl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Hsl();
      value.Hue = GetHue(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Hsl? value)
    where OpenXmlElementType: DXDraw.Hsl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHue(openXmlElement, value?.Hue);
      SetSaturation(openXmlElement, value?.Saturation);
      SetLuminance(openXmlElement, value?.Luminance);
      return openXmlElement;
    }
    return default;
  }
}
