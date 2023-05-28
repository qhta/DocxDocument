namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorTemperature Class.
/// </summary>
public static class ColorTemperatureConverter
{
  /// <summary>
  /// colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetColorTemperatureValue(DXO10D.ColorTemperature openXmlElement)
  {
    return openXmlElement?.ColorTemperatureValue?.Value;
  }
  
  private static bool CmpColorTemperatureValue(DXO10D.ColorTemperature openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColorTemperatureValue?.Value == value) return true;
    diffs?.Add(objName, "ColorTemperatureValue", openXmlElement?.ColorTemperatureValue?.Value, value);
    return false;
  }
  
  private static void SetColorTemperatureValue(DXO10D.ColorTemperature openXmlElement, Int32? value)
  {
    openXmlElement.ColorTemperatureValue = value;
  }
  
  public static DMD.ColorTemperature? CreateModelElement(DXO10D.ColorTemperature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ColorTemperature();
      value.ColorTemperatureValue = GetColorTemperatureValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ColorTemperature? openXmlElement, DMD.ColorTemperature? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorTemperatureValue(openXmlElement, value.ColorTemperatureValue, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ColorTemperature value)
    where OpenXmlElementType: DXO10D.ColorTemperature, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ColorTemperature openXmlElement, DMD.ColorTemperature value)
  {
    SetColorTemperatureValue(openXmlElement, value?.ColorTemperatureValue);
  }
}
