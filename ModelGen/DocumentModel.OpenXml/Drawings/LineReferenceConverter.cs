namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public static class LineReferenceConverter
{
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (element != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXDraw.LineReference openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelPercentage(DXDraw.LineReference openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (element != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXDraw.LineReference openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXDraw.LineReference openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (element != null)
      return DMXDraws.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXDraw.LineReference openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHslColor(DXDraw.LineReference openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (element != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXDraw.LineReference openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSystemColor(DXDraw.LineReference openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (element != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXDraw.LineReference openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXDraw.LineReference openXmlElement, DMDraws.SchemeColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXDraw.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (element != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXDraw.LineReference openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetColor(DXDraw.LineReference openXmlElement, DMDraws.PresetColor? value)
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
  
  public static DocumentModel.Drawings.LineReference? CreateModelElement(DXDraw.LineReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineReference();
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
  
  public static bool CompareModelElement(DXDraw.LineReference? openXmlElement, DMDraws.LineReference? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineReference value)
    where OpenXmlElementType: DXDraw.LineReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LineReference openXmlElement, DMDraws.LineReference value)
  {
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
  }
}
