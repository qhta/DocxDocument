namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public static class HslConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHue(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement?.Hue?.Value;
  }
  
  private static bool CmpHue(DXDraw.Hsl openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hue?.Value == value) return true;
    diffs?.Add(objName, "Hue", openXmlElement?.Hue?.Value, value);
    return false;
  }
  
  private static void SetHue(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Hue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  private static Int32? GetSaturation(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement?.Saturation?.Value;
  }
  
  private static bool CmpSaturation(DXDraw.Hsl openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Saturation?.Value == value) return true;
    diffs?.Add(objName, "Saturation", openXmlElement?.Saturation?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Saturation = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  private static Int32? GetLuminance(DXDraw.Hsl openXmlElement)
  {
    return openXmlElement?.Luminance?.Value;
  }
  
  private static bool CmpLuminance(DXDraw.Hsl openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Luminance?.Value == value) return true;
    diffs?.Add(objName, "Luminance", openXmlElement?.Luminance?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXDraw.Hsl openXmlElement, Int32? value)
  {
    openXmlElement.Luminance = value;
  }
  
  public static DocumentModel.Drawings.Hsl? CreateModelElement(DXDraw.Hsl? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.Hsl? openXmlElement, DMDraws.Hsl? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHue(openXmlElement, value.Hue, diffs, objName))
        ok = false;
      if (!CmpSaturation(openXmlElement, value.Saturation, diffs, objName))
        ok = false;
      if (!CmpLuminance(openXmlElement, value.Luminance, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Hsl value)
    where OpenXmlElementType: DXDraw.Hsl, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Hsl openXmlElement, DMDraws.Hsl value)
  {
    SetHue(openXmlElement, value?.Hue);
    SetSaturation(openXmlElement, value?.Saturation);
    SetLuminance(openXmlElement, value?.Luminance);
  }
}
