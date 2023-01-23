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
  
  private static bool CmpColorTemperatureValue(DXO2010Draw.ColorTemperature openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ColorTemperatureValue?.Value == value;
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
  
  public static bool CompareModelElement(DXO2010Draw.ColorTemperature? openXmlElement, DMDraws.ColorTemperature? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorTemperatureValue(openXmlElement, value.ColorTemperatureValue, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
