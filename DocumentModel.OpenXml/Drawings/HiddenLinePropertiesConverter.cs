namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  /// <summary>
  /// line width
  /// </summary>
  private static Int32? GetWidth(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO2010Draw.HiddenLineProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO2010Draw.HiddenLineProperties openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  private static DMDraws.LineCapKind? GetCapType(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static bool CmpCapType(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineCapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(openXmlElement?.CapType?.Value, value, diffs, objName);
  }
  
  private static void SetCapType(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMDraws.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  private static DMDraws.CompoundLineKind? GetCompoundLineType(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  private static bool CmpCompoundLineType(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.CompoundLineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value, value, diffs, objName);
  }
  
  private static void SetCompoundLineType(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.CompoundLineKind? value)
  {
    openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMDraws.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  private static DMDraws.PenAlignmentKind? GetAlignment(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PenAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName);
  }
  
  private static void SetAlignment(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMDraws.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFill(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SolidFill? GetSolidFill(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (element != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SolidFillConverter.CreateOpenXmlElement<DXDraw.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.GradientFill? GetGradientFill(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (element != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientFillConverter.CreateOpenXmlElement<DXDraw.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PatternFill? GetPatternFill(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (element != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PatternFillConverter.CreateOpenXmlElement<DXDraw.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PresetLineDashKind? GetPresetDash(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(openXmlElement.GetFirstChild<DXDraw.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PresetLineDashKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(openXmlElement.GetFirstChild<DXDraw.PresetDash>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetPresetDash(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetDash>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(itemElement, (DMDraws.PresetLineDashKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDraw.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>((DMDraws.PresetLineDashKind)value));
  }
  
  private static DMDraws.CustomDash? GetCustomDash(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CustomDash>();
    if (element != null)
      return DMXDraws.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.CustomDash? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CustomDash>(), value, diffs, objName);
  }
  
  private static void SetCustomDash(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.CustomDash? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CustomDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CustomDashConverter.CreateOpenXmlElement<DXDraw.CustomDash>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRound(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Round>() != null;
  }
  
  private static bool CmpRound(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Round>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Round", val, value);
    return false;
  }
  
  private static void SetRound(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Round>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Round();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLineJoinBevel(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.LineJoinBevel", val, value);
    return false;
  }
  
  private static void SetLineJoinBevel(DXO2010Draw.HiddenLineProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.LineJoinBevel();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Miter? GetMiter(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Miter>();
    if (element != null)
      return DMXDraws.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.Miter? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Miter>(), value, diffs, objName);
  }
  
  private static void SetMiter(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.Miter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Miter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.MiterConverter.CreateOpenXmlElement<DXDraw.Miter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineEndPropertiesType? GetHeadEnd(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HeadEnd>();
    if (element != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HeadEnd>(), value, diffs, objName);
  }
  
  private static void SetHeadEnd(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HeadEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXDraw.HeadEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineEndPropertiesType? GetTailEnd(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TailEnd>();
    if (element != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TailEnd>(), value, diffs, objName);
  }
  
  private static void SetTailEnd(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TailEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXDraw.TailEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXO2010Draw.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LinePropertiesExtensionList>();
    if (element != null)
      return DMXDraws.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LinePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LinePropertiesExtensionList>(), value, diffs, objName);
  }
  
  private static void SetLinePropertiesExtensionList(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.LinePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LinePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.LinePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HiddenLineProperties? CreateModelElement(DXO2010Draw.HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenLineProperties();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.PresetDash = GetPresetDash(openXmlElement);
      value.CustomDash = GetCustomDash(openXmlElement);
      value.Round = GetRound(openXmlElement);
      value.LineJoinBevel = GetLineJoinBevel(openXmlElement);
      value.Miter = GetMiter(openXmlElement);
      value.HeadEnd = GetHeadEnd(openXmlElement);
      value.TailEnd = GetTailEnd(openXmlElement);
      value.LinePropertiesExtensionList = GetLinePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.HiddenLineProperties? openXmlElement, DMDraws.HiddenLineProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpCapType(openXmlElement, value.CapType, diffs, objName))
        ok = false;
      if (!CmpCompoundLineType(openXmlElement, value.CompoundLineType, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpPresetDash(openXmlElement, value.PresetDash, diffs, objName))
        ok = false;
      if (!CmpCustomDash(openXmlElement, value.CustomDash, diffs, objName))
        ok = false;
      if (!CmpRound(openXmlElement, value.Round, diffs, objName))
        ok = false;
      if (!CmpLineJoinBevel(openXmlElement, value.LineJoinBevel, diffs, objName))
        ok = false;
      if (!CmpMiter(openXmlElement, value.Miter, diffs, objName))
        ok = false;
      if (!CmpHeadEnd(openXmlElement, value.HeadEnd, diffs, objName))
        ok = false;
      if (!CmpTailEnd(openXmlElement, value.TailEnd, diffs, objName))
        ok = false;
      if (!CmpLinePropertiesExtensionList(openXmlElement, value.LinePropertiesExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenLineProperties value)
    where OpenXmlElementType: DXO2010Draw.HiddenLineProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.HiddenLineProperties openXmlElement, DMDraws.HiddenLineProperties value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetCapType(openXmlElement, value?.CapType);
    SetCompoundLineType(openXmlElement, value?.CompoundLineType);
    SetAlignment(openXmlElement, value?.Alignment);
    SetNoFill(openXmlElement, value?.NoFill);
    SetSolidFill(openXmlElement, value?.SolidFill);
    SetGradientFill(openXmlElement, value?.GradientFill);
    SetPatternFill(openXmlElement, value?.PatternFill);
    SetPresetDash(openXmlElement, value?.PresetDash);
    SetCustomDash(openXmlElement, value?.CustomDash);
    SetRound(openXmlElement, value?.Round);
    SetLineJoinBevel(openXmlElement, value?.LineJoinBevel);
    SetMiter(openXmlElement, value?.Miter);
    SetHeadEnd(openXmlElement, value?.HeadEnd);
    SetTailEnd(openXmlElement, value?.TailEnd);
    SetLinePropertiesExtensionList(openXmlElement, value?.LinePropertiesExtensionList);
  }
}
