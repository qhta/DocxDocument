namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public static class FontReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMD.FontCollectionIndexKind? GetIndex(DXO13DCS.FontReference openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DMD.FontCollectionIndexKind>(openXmlElement?.Index?.Value);
  }
  
  private static bool CmpIndex(DXO13DCS.FontReference openXmlElement, DMD.FontCollectionIndexKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DMD.FontCollectionIndexKind>(openXmlElement?.Index?.Value, value, diffs, objName);
  }
  
  private static void SetIndex(DXO13DCS.FontReference openXmlElement, DMD.FontCollectionIndexKind? value)
  {
    openXmlElement.Index = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DMD.FontCollectionIndexKind>(value);
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO13DCS.FontReference openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static bool CmpModifiers(DXO13DCS.FontReference openXmlElement, DM.ListOf<String>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Modifiers, value, diffs, objName);
  }
  
  private static void SetModifiers(DXO13DCS.FontReference openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  private static DMD.RgbColorModelPercentage? GetRgbColorModelPercentage(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (element != null)
      return DMXD.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXO13DCS.FontReference openXmlElement, DMD.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXD.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelPercentage(DXO13DCS.FontReference openXmlElement, DMD.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXD.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.RgbColorModelHex? GetRgbColorModelHex(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelHex>();
    if (element != null)
      return DMXD.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO13DCS.FontReference openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXD.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelHex>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelHex(DXO13DCS.FontReference openXmlElement, DMD.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelHexConverter.CreateOpenXmlElement<DXD.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.HslColor? GetHslColor(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HslColor>();
    if (element != null)
      return DMXD.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXO13DCS.FontReference openXmlElement, DMD.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HslColor>(), value, diffs, objName);
  }
  
  private static void SetHslColor(DXO13DCS.FontReference openXmlElement, DMD.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslColorConverter.CreateOpenXmlElement<DXD.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SystemColor? GetSystemColor(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SystemColor>();
    if (element != null)
      return DMXD.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXO13DCS.FontReference openXmlElement, DMD.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SystemColor>(), value, diffs, objName);
  }
  
  private static void SetSystemColor(DXO13DCS.FontReference openXmlElement, DMD.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SystemColorConverter.CreateOpenXmlElement<DXD.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SchemeColor? GetSchemeColor(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SchemeColor>();
    if (element != null)
      return DMXD.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO13DCS.FontReference openXmlElement, DMD.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SchemeColor>(), value, diffs, objName);
  }
  
  private static void SetSchemeColor(DXO13DCS.FontReference openXmlElement, DMD.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SchemeColorConverter.CreateOpenXmlElement<DXD.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PresetColor? GetPresetColor(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetColor>();
    if (element != null)
      return DMXD.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXO13DCS.FontReference openXmlElement, DMD.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetColor>(), value, diffs, objName);
  }
  
  private static void SetPresetColor(DXO13DCS.FontReference openXmlElement, DMD.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetColorConverter.CreateOpenXmlElement<DXD.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDCS.StyleColor? GetStyleColor(DXO13DCS.FontReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.StyleColor>();
    if (element != null)
      return DMXDCS.StyleColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleColor(DXO13DCS.FontReference openXmlElement, DMDCS.StyleColor? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.StyleColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.StyleColor>(), value, diffs, objName);
  }
  
  private static void SetStyleColor(DXO13DCS.FontReference openXmlElement, DMDCS.StyleColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.StyleColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.StyleColorConverter.CreateOpenXmlElement<DXO13DCS.StyleColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.FontReference? CreateModelElement(DXO13DCS.FontReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.FontReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
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
  
  public static bool CompareModelElement(DXO13DCS.FontReference? openXmlElement, DMDCS.FontReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpModifiers(openXmlElement, value.Modifiers, diffs, objName))
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
      if (!CmpStyleColor(openXmlElement, value.StyleColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.FontReference value)
    where OpenXmlElementType: DXO13DCS.FontReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.FontReference openXmlElement, DMDCS.FontReference value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetModifiers(openXmlElement, value?.Modifiers);
    SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetHslColor(openXmlElement, value?.HslColor);
    SetSystemColor(openXmlElement, value?.SystemColor);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    SetPresetColor(openXmlElement, value?.PresetColor);
    SetStyleColor(openXmlElement, value?.StyleColor);
  }
}
