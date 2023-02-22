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
    return openXmlElement?.ColorTemperatureValue?.Value;
  }
  
  private static bool CmpColorTemperatureValue(DXO2010Draw.ColorTemperature openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColorTemperatureValue?.Value == value) return true;
    diffs?.Add(objName, "ColorTemperatureValue", openXmlElement?.ColorTemperatureValue?.Value, value);
    return false;
  }
  
  private static void SetColorTemperatureValue(DXO2010Draw.ColorTemperature openXmlElement, Int32? value)
  {
    openXmlElement.ColorTemperatureValue = value;
  }
  
  public static DocumentModel.Drawings.ColorTemperature? CreateModelElement(DXO2010Draw.ColorTemperature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorTemperature();
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ColorTemperature value)
    where OpenXmlElementType: DXO2010Draw.ColorTemperature, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ColorTemperature openXmlElement, DMDraws.ColorTemperature value)
  {
    SetColorTemperatureValue(openXmlElement, value?.ColorTemperatureValue);
    }
  }
