namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Color2Type Class.
/// </summary>
public static class Color2TypeConverter
{
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMD.RgbColorModelPercentage? GetRgbColorModelPercentage(DXD.Color2Type openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (element != null)
      return DMXD.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXD.Color2Type openXmlElement, DMD.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXD.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelPercentage(DXD.Color2Type openXmlElement, DMD.RgbColorModelPercentage? value)
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
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  private static DMD.RgbColorModelHex? GetRgbColorModelHex(DXD.Color2Type openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelHex>();
    if (element != null)
      return DMXD.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXD.Color2Type openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXD.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelHex>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelHex(DXD.Color2Type openXmlElement, DMD.RgbColorModelHex? value)
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
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  private static DMD.HslColor? GetHslColor(DXD.Color2Type openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HslColor>();
    if (element != null)
      return DMXD.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXD.Color2Type openXmlElement, DMD.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HslColor>(), value, diffs, objName);
  }
  
  private static void SetHslColor(DXD.Color2Type openXmlElement, DMD.HslColor? value)
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
  
  /// <summary>
  /// System Color.
  /// </summary>
  private static DMD.SystemColor? GetSystemColor(DXD.Color2Type openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SystemColor>();
    if (element != null)
      return DMXD.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXD.Color2Type openXmlElement, DMD.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SystemColor>(), value, diffs, objName);
  }
  
  private static void SetSystemColor(DXD.Color2Type openXmlElement, DMD.SystemColor? value)
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
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  private static DMD.PresetColor? GetPresetColor(DXD.Color2Type openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetColor>();
    if (element != null)
      return DMXD.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXD.Color2Type openXmlElement, DMD.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetColor>(), value, diffs, objName);
  }
  
  private static void SetPresetColor(DXD.Color2Type openXmlElement, DMD.PresetColor? value)
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
  
  public static DocumentModel.Drawings.Color2Type? CreateModelElement(DXD.Color2Type? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Color2Type();
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Color2Type? openXmlElement, DMD.Color2Type? value, DiffList? diffs, string? objName)
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
      if (!CmpPresetColor(openXmlElement, value.PresetColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Color2Type value)
    where OpenXmlElementType: DXD.Color2Type, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Color2Type openXmlElement, DMD.Color2Type value)
  {
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
  }
}
