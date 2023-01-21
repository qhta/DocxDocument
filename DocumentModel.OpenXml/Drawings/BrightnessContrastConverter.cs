namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public static class BrightnessContrastConverter
{
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBright(DXO2010Draw.BrightnessContrast openXmlElement)
  {
    return openXmlElement.Bright?.Value;
  }
  
  private static void SetBright(DXO2010Draw.BrightnessContrast openXmlElement, Int32? value)
  {
    openXmlElement.Bright = value;
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetContrast(DXO2010Draw.BrightnessContrast openXmlElement)
  {
    return openXmlElement.Contrast?.Value;
  }
  
  private static void SetContrast(DXO2010Draw.BrightnessContrast openXmlElement, Int32? value)
  {
    openXmlElement.Contrast = value;
  }
  
  public static DMDraws.BrightnessContrast? CreateModelElement(DXO2010Draw.BrightnessContrast? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BrightnessContrast();
      value.Bright = GetBright(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BrightnessContrast? value)
    where OpenXmlElementType: DXO2010Draw.BrightnessContrast, new()
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
