namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the StyleMatrixReferenceType Class.
/// </summary>
public static class StyleMatrixReferenceTypeConverter
{
  /// <summary>
  /// Style Matrix Index
  /// </summary>
  private static UInt32? GetIndex(DXD.StyleMatrixReferenceType openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXD.StyleMatrixReferenceType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXD.StyleMatrixReferenceType openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMD.RgbColorModelPercentage? GetRgbColorModelPercentage(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (element != null)
      return DMXD.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXD.StyleMatrixReferenceType openXmlElement, DMD.RgbColorModelPercentage? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelPercentage(DXD.StyleMatrixReferenceType openXmlElement, DMD.RgbColorModelPercentage? value)
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
  private static DMD.RgbColorModelHex? GetRgbColorModelHex(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelHex>();
    if (element != null)
      return DMXD.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXD.StyleMatrixReferenceType openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelHex>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelHex(DXD.StyleMatrixReferenceType openXmlElement, DMD.RgbColorModelHex? value)
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
  private static DMD.HslColor? GetHslColor(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HslColor>();
    if (element != null)
      return DMXD.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.HslColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HslColor>(), value, diffs, objName, propName);
  }
  
  private static void SetHslColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.HslColor? value)
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
  private static DMD.SystemColor? GetSystemColor(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SystemColor>();
    if (element != null)
      return DMXD.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.SystemColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SystemColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSystemColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.SystemColor? value)
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
  /// Scheme Color.
  /// </summary>
  private static DMD.SchemeColor? GetSchemeColor(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SchemeColor>();
    if (element != null)
      return DMXD.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.SchemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SchemeColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSchemeColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.SchemeColor? value)
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
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  private static DMD.PresetColor? GetPresetColor(DXD.StyleMatrixReferenceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetColor>();
    if (element != null)
      return DMXD.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.PresetColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetColor>(), value, diffs, objName, propName);
  }
  
  private static void SetPresetColor(DXD.StyleMatrixReferenceType openXmlElement, DMD.PresetColor? value)
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
  
  public static DocumentModel.Drawings.StyleMatrixReferenceType? CreateModelElement(DXD.StyleMatrixReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.StyleMatrixReferenceType();
      value.Index = GetIndex(openXmlElement);
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
  
  public static bool CompareModelElement(DXD.StyleMatrixReferenceType? openXmlElement, DMD.StyleMatrixReferenceType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.StyleMatrixReferenceType value)
    where OpenXmlElementType: DXD.StyleMatrixReferenceType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.StyleMatrixReferenceType openXmlElement, DMD.StyleMatrixReferenceType value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
  }
}
