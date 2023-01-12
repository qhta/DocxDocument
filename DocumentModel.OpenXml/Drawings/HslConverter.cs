namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public static class HslConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  public static Int32? GetHue(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement)
  {
    return openXmlElement?.Hue?.Value;
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement)
  {
    return openXmlElement?.Saturation?.Value;
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Saturation = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement)
  {
    return openXmlElement?.Luminance?.Value;
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Drawing.Hsl? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
