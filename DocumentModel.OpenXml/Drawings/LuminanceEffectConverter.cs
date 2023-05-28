namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Luminance.
/// </summary>
public static class LuminanceEffectConverter
{
  /// <summary>
  /// Brightness
  /// </summary>
  private static Int32? GetBrightness(DXD.LuminanceEffect openXmlElement)
  {
    return openXmlElement?.Brightness?.Value;
  }
  
  private static bool CmpBrightness(DXD.LuminanceEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Brightness?.Value == value) return true;
    diffs?.Add(objName, "Brightness", openXmlElement?.Brightness?.Value, value);
    return false;
  }
  
  private static void SetBrightness(DXD.LuminanceEffect openXmlElement, Int32? value)
  {
    openXmlElement.Brightness = value;
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  private static Int32? GetContrast(DXD.LuminanceEffect openXmlElement)
  {
    return openXmlElement?.Contrast?.Value;
  }
  
  private static bool CmpContrast(DXD.LuminanceEffect openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Contrast?.Value == value) return true;
    diffs?.Add(objName, "Contrast", openXmlElement?.Contrast?.Value, value);
    return false;
  }
  
  private static void SetContrast(DXD.LuminanceEffect openXmlElement, Int32? value)
  {
    openXmlElement.Contrast = value;
  }
  
  public static DMD.LuminanceEffect? CreateModelElement(DXD.LuminanceEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.LuminanceEffect();
      value.Brightness = GetBrightness(openXmlElement);
      value.Contrast = GetContrast(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.LuminanceEffect? openXmlElement, DMD.LuminanceEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBrightness(openXmlElement, value.Brightness, diffs, objName, propName))
        ok = false;
      if (!CmpContrast(openXmlElement, value.Contrast, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LuminanceEffect value)
    where OpenXmlElementType: DXD.LuminanceEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LuminanceEffect openXmlElement, DMD.LuminanceEffect value)
  {
    SetBrightness(openXmlElement, value?.Brightness);
    SetContrast(openXmlElement, value?.Contrast);
  }
}
