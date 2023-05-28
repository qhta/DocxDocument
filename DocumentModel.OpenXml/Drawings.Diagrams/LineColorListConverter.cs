namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Line Color List.
/// </summary>
public static class LineColorListConverter
{
  private static DMD.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (element != null)
      return DMXD.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXDD.LineColorList openXmlElement, DMD.RgbColorModelPercentage? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelPercentage(DXDD.LineColorList openXmlElement, DMD.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXD.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.RgbColorModelHex? GetRgbColorModelHex(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelHex>();
    if (element != null)
      return DMXD.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXDD.LineColorList openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelHex>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelHex(DXDD.LineColorList openXmlElement, DMD.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelHexConverter.CreateOpenXmlElement<DXD.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HslColor? GetHslColor(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HslColor>();
    if (element != null)
      return DMXD.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXDD.LineColorList openXmlElement, DMD.HslColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HslColor>(), value, diffs, objName, propName);
  }
  
  private static void SetHslColor(DXDD.LineColorList openXmlElement, DMD.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslColorConverter.CreateOpenXmlElement<DXD.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SystemColor? GetSystemColor(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SystemColor>();
    if (element != null)
      return DMXD.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXDD.LineColorList openXmlElement, DMD.SystemColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SystemColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSystemColor(DXDD.LineColorList openXmlElement, DMD.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SystemColorConverter.CreateOpenXmlElement<DXD.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SchemeColor? GetSchemeColor(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SchemeColor>();
    if (element != null)
      return DMXD.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXDD.LineColorList openXmlElement, DMD.SchemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SchemeColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSchemeColor(DXDD.LineColorList openXmlElement, DMD.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SchemeColorConverter.CreateOpenXmlElement<DXD.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetColor? GetPresetColor(DXDD.LineColorList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetColor>();
    if (element != null)
      return DMXD.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXDD.LineColorList openXmlElement, DMD.PresetColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetColor>(), value, diffs, objName, propName);
  }
  
  private static void SetPresetColor(DXDD.LineColorList openXmlElement, DMD.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetColorConverter.CreateOpenXmlElement<DXD.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.LineColorList? CreateModelElement(DXDD.LineColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.LineColorList();
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
  
  public static bool CompareModelElement(DXDD.LineColorList? openXmlElement, DMDD.LineColorList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRgbColorModelPercentage(openXmlElement, value.RgbColorModelPercentage, diffs, objName, propName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName, propName))
        ok = false;
      if (!CmpHslColor(openXmlElement, value.HslColor, diffs, objName, propName))
        ok = false;
      if (!CmpSystemColor(openXmlElement, value.SystemColor, diffs, objName, propName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName, propName))
        ok = false;
      if (!CmpPresetColor(openXmlElement, value.PresetColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.LineColorList value)
    where OpenXmlElementType: DXDD.LineColorList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.LineColorList openXmlElement, DMDD.LineColorList value)
  {
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
  }
}
