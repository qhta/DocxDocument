namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public static class ColorTemperatureConverter
{
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetColorTemperatureValue(DXO2010Draw.ColorTemperature openXmlElement)
  {
    return openXmlElement.ColorTemperatureValue?.Value;
  }
  
  private static void SetColorTemperatureValue(DXO2010Draw.ColorTemperature openXmlElement, Int32? value)
  {
    openXmlElement.ColorTemperatureValue = value;
  }
  
  public static DMDraws.ColorTemperature? CreateModelElement(DXO2010Draw.ColorTemperature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ColorTemperature();
      value.ColorTemperatureValue = GetColorTemperatureValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ColorTemperature? value)
    where OpenXmlElementType: DXO2010Draw.ColorTemperature, new()
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
