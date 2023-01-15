using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ColorTemperature Class.
/// </summary>
public static class ColorTemperatureConverter
{
  /// <summary>
  ///   colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetColorTemperatureValue(ColorTemperature? openXmlElement)
  {
    return openXmlElement?.ColorTemperatureValue?.Value;
  }

  public static void SetColorTemperatureValue(ColorTemperature? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColorTemperatureValue = value;
  }

  public static DocumentModel.Drawings.ColorTemperature? CreateModelElement(ColorTemperature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorTemperature();
      value.ColorTemperatureValue = GetColorTemperatureValue(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ColorTemperature? value)
    where OpenXmlElementType : ColorTemperature, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorTemperatureValue(openXmlElement, value?.ColorTemperatureValue);
      return openXmlElement;
    }
    return default;
  }
}