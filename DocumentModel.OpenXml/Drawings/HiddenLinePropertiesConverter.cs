namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  /// <summary>
  /// line width
  /// </summary>
  private static Int32? GetWidth(DXO10D.HiddenLineProperties openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO10D.HiddenLineProperties openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO10D.HiddenLineProperties openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  private static DMD.LineCapKind? GetCapType(DXO10D.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMD.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static bool CmpCapType(DXO10D.HiddenLineProperties openXmlElement, DMD.LineCapKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMD.LineCapKind>(openXmlElement?.CapType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCapType(DXO10D.HiddenLineProperties openXmlElement, DMD.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DMD.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  private static DMD.CompoundLineKind? GetCompoundLineType(DXO10D.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMD.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  private static bool CmpCompoundLineType(DXO10D.HiddenLineProperties openXmlElement, DMD.CompoundLineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMD.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCompoundLineType(DXO10D.HiddenLineProperties openXmlElement, DMD.CompoundLineKind? value)
  {
    openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DMD.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  private static DMD.PenAlignmentKind? GetAlignment(DXO10D.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMD.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO10D.HiddenLineProperties openXmlElement, DMD.PenAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMD.PenAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXO10D.HiddenLineProperties openXmlElement, DMD.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DMD.PenAlignmentKind>(value);
  }
  
  private static DMD.PresetLineDashKind? GetPresetDash(DXO10D.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXO10D.HiddenLineProperties openXmlElement, DMD.PresetLineDashKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetDash(DXO10D.HiddenLineProperties openXmlElement, DMD.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetDash>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(itemElement, (DMD.PresetLineDashKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXD.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>((DMD.PresetLineDashKind)value));
  }
  
  private static DMD.CustomDash? GetCustomDash(DXO10D.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomDash>();
    if (element != null)
      return DMXD.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXO10D.HiddenLineProperties openXmlElement, DMD.CustomDash? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomDash>(), value, diffs, objName, propName);
  }
  
  private static void SetCustomDash(DXO10D.HiddenLineProperties openXmlElement, DMD.CustomDash? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomDashConverter.CreateOpenXmlElement<DXD.CustomDash>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetRound(DXO10D.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Round>() != null;
  }
  
  private static bool CmpRound(DXO10D.HiddenLineProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Round>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Round", val, value);
    return false;
  }
  
  private static void SetRound(DXO10D.HiddenLineProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Round>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Round();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetLineJoinBevel(DXO10D.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXO10D.HiddenLineProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.LineJoinBevel", val, value);
    return false;
  }
  
  private static void SetLineJoinBevel(DXO10D.HiddenLineProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.LineJoinBevel>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.LineJoinBevel();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Miter? GetMiter(DXO10D.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Miter>();
    if (element != null)
      return DMXD.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXO10D.HiddenLineProperties openXmlElement, DMD.Miter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Miter>(), value, diffs, objName, propName);
  }
  
  private static void SetMiter(DXO10D.HiddenLineProperties openXmlElement, DMD.Miter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Miter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.MiterConverter.CreateOpenXmlElement<DXD.Miter>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetHeadEnd(DXO10D.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HeadEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXO10D.HiddenLineProperties openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HeadEnd>(), value, diffs, objName, propName);
  }
  
  private static void SetHeadEnd(DXO10D.HiddenLineProperties openXmlElement, DMD.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HeadEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.HeadEnd>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetTailEnd(DXO10D.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TailEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXO10D.HiddenLineProperties openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TailEnd>(), value, diffs, objName, propName);
  }
  
  private static void SetTailEnd(DXO10D.HiddenLineProperties openXmlElement, DMD.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TailEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.TailEnd>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXO10D.HiddenLineProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (element != null)
      return DMXD.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXO10D.HiddenLineProperties openXmlElement, DMD.LinePropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetLinePropertiesExtensionList(DXO10D.HiddenLineProperties openXmlElement, DMD.LinePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.LinePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.HiddenLineProperties? CreateModelElement(DXO10D.HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.HiddenLineProperties();
      model.Width = GetWidth(openXmlElement);
      model.CapType = GetCapType(openXmlElement);
      model.CompoundLineType = GetCompoundLineType(openXmlElement);
      model.Alignment = GetAlignment(openXmlElement);
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      model.PresetDash = GetPresetDash(openXmlElement);
      model.CustomDash = GetCustomDash(openXmlElement);
      model.Round = GetRound(openXmlElement);
      model.LineJoinBevel = GetLineJoinBevel(openXmlElement);
      model.Miter = GetMiter(openXmlElement);
      model.HeadEnd = GetHeadEnd(openXmlElement);
      model.TailEnd = GetTailEnd(openXmlElement);
      model.LinePropertiesExtensionList = GetLinePropertiesExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.HiddenLineProperties? openXmlElement, DMD.HiddenLineProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, model.Width, diffs, objName, propName))
        ok = false;
      if (!CmpCapType(openXmlElement, model.CapType, diffs, objName, propName))
        ok = false;
      if (!CmpCompoundLineType(openXmlElement, model.CompoundLineType, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, model.Alignment, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpPresetDash(openXmlElement, model.PresetDash, diffs, objName, propName))
        ok = false;
      if (!CmpCustomDash(openXmlElement, model.CustomDash, diffs, objName, propName))
        ok = false;
      if (!CmpRound(openXmlElement, model.Round, diffs, objName, propName))
        ok = false;
      if (!CmpLineJoinBevel(openXmlElement, model.LineJoinBevel, diffs, objName, propName))
        ok = false;
      if (!CmpMiter(openXmlElement, model.Miter, diffs, objName, propName))
        ok = false;
      if (!CmpHeadEnd(openXmlElement, model.HeadEnd, diffs, objName, propName))
        ok = false;
      if (!CmpTailEnd(openXmlElement, model.TailEnd, diffs, objName, propName))
        ok = false;
      if (!CmpLinePropertiesExtensionList(openXmlElement, model.LinePropertiesExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HiddenLineProperties model)
    where OpenXmlElementType: DXO10D.HiddenLineProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.HiddenLineProperties openXmlElement, DMD.HiddenLineProperties model)
  {
    SetWidth(openXmlElement, model.Width);
    SetCapType(openXmlElement, model.CapType);
    SetCompoundLineType(openXmlElement, model.CompoundLineType);
    SetAlignment(openXmlElement, model.Alignment);
    FillConverter.UpdateOpenXmlFillElement(openXmlElement, model.Fill);
    SetPresetDash(openXmlElement, model.PresetDash);
    SetCustomDash(openXmlElement, model.CustomDash);
    SetRound(openXmlElement, model.Round);
    SetLineJoinBevel(openXmlElement, model.LineJoinBevel);
    SetMiter(openXmlElement, model.Miter);
    SetHeadEnd(openXmlElement, model.HeadEnd);
    SetTailEnd(openXmlElement, model.TailEnd);
    SetLinePropertiesExtensionList(openXmlElement, model.LinePropertiesExtensionList);
  }
}
