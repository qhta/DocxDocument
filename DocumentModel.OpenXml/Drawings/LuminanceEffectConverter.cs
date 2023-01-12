namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Luminance.
/// </summary>
public static class LuminanceEffectConverter
{
  /// <summary>
  /// Brightness
  /// </summary>
  public static Int32? GetBrightness(DocumentFormat.OpenXml.Drawing.LuminanceEffect? openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }
  
  public static void SetBrightness(DocumentFormat.OpenXml.Drawing.LuminanceEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Brightness = value;
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public static Int32? GetContrast(DocumentFormat.OpenXml.Drawing.LuminanceEffect? openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }
  
  public static void SetContrast(DocumentFormat.OpenXml.Drawing.LuminanceEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Contrast = value;
  }
  
  public static DocumentModel.Drawings.LuminanceEffect? CreateModelElement(DocumentFormat.OpenXml.Drawing.LuminanceEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LuminanceEffect();
      value.Brightness = GetBrightness(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LuminanceEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LuminanceEffect, new()
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
