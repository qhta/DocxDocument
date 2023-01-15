using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BrightnessContrast Class.
/// </summary>
public static class BrightnessContrastConverter
{
  /// <summary>
  ///   bright, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBright(BrightnessContrast? openXmlElement)
  {
    return openXmlElement?.Bright?.Value;
  }

  public static void SetBright(BrightnessContrast? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bright = value;
  }

  /// <summary>
  ///   contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetContrast(BrightnessContrast? openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }

  public static void SetContrast(BrightnessContrast? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Contrast = value;
  }

  public static DocumentModel.Drawings.BrightnessContrast? CreateModelElement(BrightnessContrast? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BrightnessContrast();
      value.Bright = GetBright(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BrightnessContrast? value)
    where OpenXmlElementType : BrightnessContrast, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBright(openXmlElement, value?.Bright);
      SetContrast(openXmlElement, value?.Contrast);
      return openXmlElement;
    }
    return default;
  }
}