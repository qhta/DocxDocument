namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public static class OutlineConverter
{
  private static Boolean GetNoFill(DXD.Outline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXD.Outline openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXD.Outline openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.NoFill();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SolidFill? GetSolidFill(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXD.Outline openXmlElement, DMD.SolidFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName, propName);
  }
  
  private static void SetSolidFill(DXD.Outline openXmlElement, DMD.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.GradientFill? GetGradientFill(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXD.Outline openXmlElement, DMD.GradientFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName, propName);
  }
  
  private static void SetGradientFill(DXD.Outline openXmlElement, DMD.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXD.Outline openXmlElement, DMD.PatternFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName, propName);
  }
  
  private static void SetPatternFill(DXD.Outline openXmlElement, DMD.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetLineDashKind? GetPresetDash(DXD.Outline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXD.Outline openXmlElement, DMD.PresetLineDashKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetDash(DXD.Outline openXmlElement, DMD.PresetLineDashKind? value)
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
  
  private static DMD.CustomDash? GetCustomDash(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomDash>();
    if (element != null)
      return DMXD.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXD.Outline openXmlElement, DMD.CustomDash? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomDash>(), value, diffs, objName, propName);
  }
  
  private static void SetCustomDash(DXD.Outline openXmlElement, DMD.CustomDash? value)
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
  
  private static Boolean GetRound(DXD.Outline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Round>() != null;
  }
  
  private static bool CmpRound(DXD.Outline openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Round>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Round", val, value);
    return false;
  }
  
  private static void SetRound(DXD.Outline openXmlElement, Boolean? value)
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
  
  private static Boolean GetLineJoinBevel(DXD.Outline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXD.Outline openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.LineJoinBevel", val, value);
    return false;
  }
  
  private static void SetLineJoinBevel(DXD.Outline openXmlElement, Boolean? value)
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
  
  private static DMD.Miter? GetMiter(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Miter>();
    if (element != null)
      return DMXD.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXD.Outline openXmlElement, DMD.Miter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Miter>(), value, diffs, objName, propName);
  }
  
  private static void SetMiter(DXD.Outline openXmlElement, DMD.Miter? value)
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
  
  private static DMD.LineEndPropertiesType? GetHeadEnd(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HeadEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXD.Outline openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HeadEnd>(), value, diffs, objName, propName);
  }
  
  private static void SetHeadEnd(DXD.Outline openXmlElement, DMD.LineEndPropertiesType? value)
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
  
  private static DMD.LineEndPropertiesType? GetTailEnd(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TailEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXD.Outline openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TailEnd>(), value, diffs, objName, propName);
  }
  
  private static void SetTailEnd(DXD.Outline openXmlElement, DMD.LineEndPropertiesType? value)
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
  
  private static DMD.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXD.Outline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (element != null)
      return DMXD.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXD.Outline openXmlElement, DMD.LinePropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetLinePropertiesExtensionList(DXD.Outline openXmlElement, DMD.LinePropertiesExtensionList? value)
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
  
  public static DocumentModel.Drawings.Outline? CreateModelElement(DXD.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Outline();
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
  
  public static bool CompareModelElement(DXD.Outline? openXmlElement, DMD.Outline? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName, propName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName, propName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName, propName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName, propName))
        ok = false;
      if (!CmpPresetDash(openXmlElement, value.PresetDash, diffs, objName, propName))
        ok = false;
      if (!CmpCustomDash(openXmlElement, value.CustomDash, diffs, objName, propName))
        ok = false;
      if (!CmpRound(openXmlElement, value.Round, diffs, objName, propName))
        ok = false;
      if (!CmpLineJoinBevel(openXmlElement, value.LineJoinBevel, diffs, objName, propName))
        ok = false;
      if (!CmpMiter(openXmlElement, value.Miter, diffs, objName, propName))
        ok = false;
      if (!CmpHeadEnd(openXmlElement, value.HeadEnd, diffs, objName, propName))
        ok = false;
      if (!CmpTailEnd(openXmlElement, value.TailEnd, diffs, objName, propName))
        ok = false;
      if (!CmpLinePropertiesExtensionList(openXmlElement, value.LinePropertiesExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Outline value)
    where OpenXmlElementType: DXD.Outline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Outline openXmlElement, DMD.Outline value)
  {
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
