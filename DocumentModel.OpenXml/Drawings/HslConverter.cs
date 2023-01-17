namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public static class HslConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement)
  {
    return openXmlElement.Hue?.Value;
  }
  
  private static void SetHue(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  private static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement)
  {
    return openXmlElement.Saturation?.Value;
  }
  
  private static void SetSaturation(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Saturation = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  private static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement)
  {
    return openXmlElement.Luminance?.Value;
  }
  
  private static void SetLuminance(DocumentFormat.OpenXml.Drawing.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Luminance = value;
  }
  
  public static DocumentModel.Drawings.Hsl? CreateModelElement(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Hsl();
      value.Hue = GetHue(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Hsl? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Hsl, new()
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
