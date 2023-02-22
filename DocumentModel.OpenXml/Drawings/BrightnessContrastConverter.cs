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
    return openXmlElement?.Bright?.Value;
  }
  
  private static bool CmpBright(DXO2010Draw.BrightnessContrast openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bright?.Value == value) return true;
    diffs?.Add(objName, "Bright", openXmlElement?.Bright?.Value, value);
    return false;
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
    return openXmlElement?.Contrast?.Value;
  }
  
  private static bool CmpContrast(DXO2010Draw.BrightnessContrast openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Contrast?.Value == value) return true;
    diffs?.Add(objName, "Contrast", openXmlElement?.Contrast?.Value, value);
    return false;
  }
  
  private static void SetContrast(DXO2010Draw.BrightnessContrast openXmlElement, Int32? value)
  {
    openXmlElement.Contrast = value;
  }
  
  public static DocumentModel.Drawings.BrightnessContrast? CreateModelElement(DXO2010Draw.BrightnessContrast? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010Draw.BrightnessContrast? openXmlElement, DMDraws.BrightnessContrast? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBright(openXmlElement, value.Bright, diffs, objName))
        ok = false;
      if (!CmpContrast(openXmlElement, value.Contrast, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BrightnessContrast value)
    where OpenXmlElementType: DXO2010Draw.BrightnessContrast, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.BrightnessContrast openXmlElement, DMDraws.BrightnessContrast value)
  {
    SetBright(openXmlElement, value?.Bright);
    SetContrast(openXmlElement, value?.Contrast);
    }
  }
