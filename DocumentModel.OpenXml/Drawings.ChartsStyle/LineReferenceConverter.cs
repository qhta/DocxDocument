namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the LineReference Class converter from/to OpenXml.
///</summary>
public static class LineReferenceConverter
{
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (element != null)
      return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelPercentage(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (element != null)
      return DMXDraws.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelHex(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.RgbColorModelHex? value)
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
  
  private static DMDraws.HslColor? GetHslColor(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HslColor>();
    if (element != null)
      return DMXDraws.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName);
  }
  
  private static void SetHslColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.HslColor? value)
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
  
  private static DMDraws.SystemColor? GetSystemColor(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SystemColor>();
    if (element != null)
      return DMXDraws.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName);
  }
  
  private static void SetSystemColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.SystemColor? value)
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
  
  private static DMDraws.SchemeColor? GetSchemeColor(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SchemeColor>();
    if (element != null)
      return DMXDraws.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName);
  }
  
  private static void SetSchemeColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.SchemeColor? value)
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
  
  private static DMDraws.PresetColor? GetPresetColor(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetColor>();
    if (element != null)
      return DMXDraws.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName);
  }
  
  private static void SetPresetColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDraws.PresetColor? value)
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
  
  private static DMDrawsChartsStyle.StyleColor? GetStyleColor(DXO2013DrawChartStyle.LineReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.StyleColor>();
    if (element != null)
      return DMXDrawsChartsStyle.StyleColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDrawsChartsStyle.StyleColor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.StyleColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.StyleColor>(), value, diffs, objName);
  }
  
  private static void SetStyleColor(DXO2013DrawChartStyle.LineReference openXmlElement, DMDrawsChartsStyle.StyleColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.StyleColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.StyleColorConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.StyleColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.LineReference? CreateModelElement(DXO2013DrawChartStyle.LineReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.LineReference();
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      value.StyleColor = GetStyleColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.LineReference? openXmlElement, DMDrawsChartsStyle.LineReference? value, DiffList? diffs, string? objName)
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
      if (!CmpStyleColor(openXmlElement, value.StyleColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.LineReference value)
    where OpenXmlElementType: DXO2013DrawChartStyle.LineReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChartStyle.LineReference openXmlElement, DMDrawsChartsStyle.LineReference value)
  {
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
    SetStyleColor(openXmlElement, value?.StyleColor);
  }
}
