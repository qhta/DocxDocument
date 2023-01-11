namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public static class BrightnessContrastConverter
{
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetBright(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? openXmlElement)
  {
    return openXmlElement?.Bright?.Value;
  }
  
  public static void SetBright(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bright = value;
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetContrast(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }
  
  public static void SetContrast(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Contrast = value;
  }
  
  public static DocumentModel.Drawings.BrightnessContrast? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
