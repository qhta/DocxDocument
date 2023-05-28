namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public static class HslConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DXD.Hsl openXmlElement)
  {
    return openXmlElement?.Hue?.Value;
  }
  
  private static bool CmpHue(DXD.Hsl openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Hue?.Value == value) return true;
    diffs?.Add(objName, "Hue", openXmlElement?.Hue?.Value, value);
    return false;
  }
  
  private static void SetHue(DXD.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  private static Int32? GetSaturation(DXD.Hsl openXmlElement)
  {
    return openXmlElement?.Saturation?.Value;
  }
  
  private static bool CmpSaturation(DXD.Hsl openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Saturation?.Value == value) return true;
    diffs?.Add(objName, "Saturation", openXmlElement?.Saturation?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXD.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Saturation = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  private static Int32? GetLuminance(DXD.Hsl openXmlElement)
  {
    return openXmlElement?.Luminance?.Value;
  }
  
  private static bool CmpLuminance(DXD.Hsl openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Luminance?.Value == value) return true;
    diffs?.Add(objName, "Luminance", openXmlElement?.Luminance?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXD.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Luminance = value;
  }
  
  public static DMD.Hsl? CreateModelElement(DXD.Hsl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Hsl();
      value.Hue = GetHue(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Hsl? openXmlElement, DMD.Hsl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHue(openXmlElement, value.Hue, diffs, objName, propName))
        ok = false;
      if (!CmpSaturation(openXmlElement, value.Saturation, diffs, objName, propName))
        ok = false;
      if (!CmpLuminance(openXmlElement, value.Luminance, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Hsl value)
    where OpenXmlElementType: DXD.Hsl, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Hsl openXmlElement, DMD.Hsl value)
  {
    SetHue(openXmlElement, value?.Hue);
    SetSaturation(openXmlElement, value?.Saturation);
    SetLuminance(openXmlElement, value?.Luminance);
  }
}
