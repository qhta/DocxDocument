namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Underline Stroke.
/// </summary>
public static class UnderlineConverter
{
  private static Boolean? GetNoFill(DXD.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXD.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXD.Underline openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SolidFill? GetSolidFill(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXD.Underline openXmlElement, DMD.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXD.Underline openXmlElement, DMD.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.GradientFill? GetGradientFill(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXD.Underline openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXD.Underline openXmlElement, DMD.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXD.Underline openXmlElement, DMD.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXD.Underline openXmlElement, DMD.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PresetLineDashKind? GetPresetDash(DXD.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXD.Underline openXmlElement, DMD.PresetLineDashKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetPresetDash(DXD.Underline openXmlElement, DMD.PresetLineDashKind? value)
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
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXD.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>((DMD.PresetLineDashKind)value));
  }
  
  private static DMD.CustomDash? GetCustomDash(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomDash>();
    if (element != null)
      return DMXD.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXD.Underline openXmlElement, DMD.CustomDash? value, DiffList? diffs, string? objName)
  {
    return DMXD.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomDash>(), value, diffs, objName);
  }
  
  private static void SetCustomDash(DXD.Underline openXmlElement, DMD.CustomDash? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomDashConverter.CreateOpenXmlElement<DXD.CustomDash>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRound(DXD.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Round>() != null;
  }
  
  private static bool CmpRound(DXD.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Round>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Round", val, value);
    return false;
  }
  
  private static void SetRound(DXD.Underline openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetLineJoinBevel(DXD.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXD.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.LineJoinBevel", val, value);
    return false;
  }
  
  private static void SetLineJoinBevel(DXD.Underline openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Miter? GetMiter(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Miter>();
    if (element != null)
      return DMXD.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXD.Underline openXmlElement, DMD.Miter? value, DiffList? diffs, string? objName)
  {
    return DMXD.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Miter>(), value, diffs, objName);
  }
  
  private static void SetMiter(DXD.Underline openXmlElement, DMD.Miter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Miter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.MiterConverter.CreateOpenXmlElement<DXD.Miter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetHeadEnd(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HeadEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HeadEnd>(), value, diffs, objName);
  }
  
  private static void SetHeadEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HeadEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.HeadEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetTailEnd(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TailEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TailEnd>(), value, diffs, objName);
  }
  
  private static void SetTailEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TailEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.TailEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (element != null)
      return DMXD.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXD.Underline openXmlElement, DMD.LinePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>(), value, diffs, objName);
  }
  
  private static void SetLinePropertiesExtensionList(DXD.Underline openXmlElement, DMD.LinePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.LinePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Underline? CreateModelElement(DXD.Underline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Underline();
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
  
  public static bool CompareModelElement(DXD.Underline? openXmlElement, DMD.Underline? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Underline value)
    where OpenXmlElementType: DXD.Underline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Underline openXmlElement, DMD.Underline value)
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
