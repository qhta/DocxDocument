namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Gradient stops.
/// </summary>
public static class GradientStopConverter
{
  /// <summary>
  /// Position
  /// </summary>
  private static Int32? GetPosition(DXDraw.GradientStop openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXDraw.GradientStop openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXDraw.GradientStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (element != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXDraw.GradientStop openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelPercentage(DXDraw.GradientStop openXmlElement, DMDraws.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXDraw.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (element != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXDraw.GradientStop openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXDraw.GradientStop openXmlElement, DMDraws.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelHexConverter.CreateOpenXmlElement<DXDraw.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  private static DMDraws.HslColor? GetHslColor(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (element != null)
      return DMXDraws.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXDraw.GradientStop openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHslColor(DXDraw.GradientStop openXmlElement, DMDraws.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HslColorConverter.CreateOpenXmlElement<DXDraw.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  private static DMDraws.SystemColor? GetSystemColor(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (element != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXDraw.GradientStop openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSystemColor(DXDraw.GradientStop openXmlElement, DMDraws.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SystemColorConverter.CreateOpenXmlElement<DXDraw.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  private static DMDraws.SchemeColor? GetSchemeColor(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (element != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXDraw.GradientStop openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXDraw.GradientStop openXmlElement, DMDraws.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SchemeColorConverter.CreateOpenXmlElement<DXDraw.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  private static DMDraws.PresetColor? GetPresetColor(DXDraw.GradientStop openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (element != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXDraw.GradientStop openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetColor(DXDraw.GradientStop openXmlElement, DMDraws.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetColorConverter.CreateOpenXmlElement<DXDraw.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.GradientStop? CreateModelElement(DXDraw.GradientStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientStop();
      value.Position = GetPosition(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.GradientStop? openXmlElement, DMDraws.GradientStop? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpRgbColorModelPercentage(openXmlElement, value.RgbColorModelPercentage, diffs, objName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName))
        ok = false;
      if (!CmpHslColor(openXmlElement, value.HslColor, diffs, objName))
        ok = false;
      if (!CmpSystemColor(openXmlElement, value.SystemColor, diffs, objName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName))
        ok = false;
      if (!CmpPresetColor(openXmlElement, value.PresetColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GradientStop? value)
    where OpenXmlElementType: DXDraw.GradientStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}
