namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Effect Color List.
/// </summary>
public static class TextEffectColorListConverter
{
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>());
  }
  
  private static bool CmpRgbColorModelPercentage(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelPercentage(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.RgbColorModelHexConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>());
  }
  
  private static bool CmpRgbColorModelHex(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.HslColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>());
  }
  
  private static bool CmpHslColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHslColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.SystemColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>());
  }
  
  private static bool CmpSystemColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSystemColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.SchemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>());
  }
  
  private static bool CmpSchemeColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.SchemeColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXDrawDgms.TextEffectColorList openXmlElement)
  {
    return DMXDraws.PresetColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>());
  }
  
  private static bool CmpPresetColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetColor(DXDrawDgms.TextEffectColorList openXmlElement, DMDraws.PresetColor? value)
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
  
  public static DMDrawsDgms.TextEffectColorList? CreateModelElement(DXDrawDgms.TextEffectColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.TextEffectColorList();
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
  
  public static bool CompareModelElement(DXDrawDgms.TextEffectColorList? openXmlElement, DMDrawsDgms.TextEffectColorList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.TextEffectColorList? value)
    where OpenXmlElementType: DXDrawDgms.TextEffectColorList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
