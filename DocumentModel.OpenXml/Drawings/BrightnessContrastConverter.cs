namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public static class BrightnessContrastConverter
{
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBright(DXO10D.BrightnessContrast openXmlElement)
  {
    return openXmlElement?.Bright?.Value;
  }
  
  private static bool CmpBright(DXO10D.BrightnessContrast openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bright?.Value == value) return true;
    diffs?.Add(objName, "Bright", openXmlElement?.Bright?.Value, value);
    return false;
  }
  
  private static void SetBright(DXO10D.BrightnessContrast openXmlElement, Int32? value)
  {
    openXmlElement.Bright = value;
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetContrast(DXO10D.BrightnessContrast openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }
  
  private static bool CmpContrast(DXO10D.BrightnessContrast openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Contrast?.Value == value) return true;
    diffs?.Add(objName, "Contrast", openXmlElement?.Contrast?.Value, value);
    return false;
  }
  
  private static void SetContrast(DXO10D.BrightnessContrast openXmlElement, Int32? value)
  {
    openXmlElement.Contrast = value;
  }
  
  public static DMD.BrightnessContrast? CreateModelElement(DXO10D.BrightnessContrast? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BrightnessContrast();
      value.Bright = GetBright(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.BrightnessContrast? openXmlElement, DMD.BrightnessContrast? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBright(openXmlElement, value.Bright, diffs, objName, propName))
        ok = false;
      if (!CmpContrast(openXmlElement, value.Contrast, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BrightnessContrast value)
    where OpenXmlElementType: DXO10D.BrightnessContrast, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.BrightnessContrast openXmlElement, DMD.BrightnessContrast value)
  {
    SetBright(openXmlElement, value?.Bright);
    SetContrast(openXmlElement, value?.Contrast);
  }
}
