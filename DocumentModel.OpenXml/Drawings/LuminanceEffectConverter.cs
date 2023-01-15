using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Luminance.
/// </summary>
public static class LuminanceEffectConverter
{
  /// <summary>
  ///   Brightness
  /// </summary>
  public static Int32? GetBrightness(LuminanceEffect? openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }

  public static void SetBrightness(LuminanceEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Brightness = value;
  }

  /// <summary>
  ///   Contrast
  /// </summary>
  public static Int32? GetContrast(LuminanceEffect? openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }

  public static void SetContrast(LuminanceEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Contrast = value;
  }

  public static DocumentModel.Drawings.LuminanceEffect? CreateModelElement(LuminanceEffect? openXmlElement)
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
    where OpenXmlElementType : LuminanceEffect, new()
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