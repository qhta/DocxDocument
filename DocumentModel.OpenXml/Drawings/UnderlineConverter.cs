namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Underline Stroke.
/// </summary>
public static class UnderlineConverter
{
  private static Boolean? GetNoFill(DXDraw.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXDraw.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXDraw.Underline openXmlElement, Boolean? value)
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
  
  private static DMDraws.SolidFill? GetSolidFill(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (element != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXDraw.Underline openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXDraw.Underline openXmlElement, DMDraws.SolidFill? value)
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
  
  private static DMDraws.GradientFill? GetGradientFill(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (element != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXDraw.Underline openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXDraw.Underline openXmlElement, DMDraws.GradientFill? value)
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
  
  private static DMDraws.PatternFill? GetPatternFill(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (element != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXDraw.Underline openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXDraw.Underline openXmlElement, DMDraws.PatternFill? value)
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
  
  private static DMDraws.PresetLineDashKind? GetPresetDash(DXDraw.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(openXmlElement.GetFirstChild<DXDraw.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXDraw.Underline openXmlElement, DMDraws.PresetLineDashKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMDraws.PresetLineDashKind>(openXmlElement.GetFirstChild<DXDraw.PresetDash>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetPresetDash(DXDraw.Underline openXmlElement, DMDraws.PresetLineDashKind? value)
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
  
  private static DMDraws.CustomDash? GetCustomDash(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CustomDash>();
    if (element != null)
      return DMXDraws.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXDraw.Underline openXmlElement, DMDraws.CustomDash? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CustomDash>(), value, diffs, objName);
  }
  
  private static void SetCustomDash(DXDraw.Underline openXmlElement, DMDraws.CustomDash? value)
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
  
  private static Boolean? GetRound(DXDraw.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Round>() != null;
  }
  
  private static bool CmpRound(DXDraw.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Round>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Round", val, value);
    return false;
  }
  
  private static void SetRound(DXDraw.Underline openXmlElement, Boolean? value)
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
  
  private static Boolean? GetLineJoinBevel(DXDraw.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXDraw.Underline openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.LineJoinBevel>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.LineJoinBevel", val, value);
    return false;
  }
  
  private static void SetLineJoinBevel(DXDraw.Underline openXmlElement, Boolean? value)
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
  
  private static DMDraws.Miter? GetMiter(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Miter>();
    if (element != null)
      return DMXDraws.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXDraw.Underline openXmlElement, DMDraws.Miter? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Miter>(), value, diffs, objName);
  }
  
  private static void SetMiter(DXDraw.Underline openXmlElement, DMDraws.Miter? value)
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
  
  private static DMDraws.LineEndPropertiesType? GetHeadEnd(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.HeadEnd>();
    if (element != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXDraw.Underline openXmlElement, DMDraws.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.HeadEnd>(), value, diffs, objName);
  }
  
  private static void SetHeadEnd(DXDraw.Underline openXmlElement, DMDraws.LineEndPropertiesType? value)
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
  
  private static DMDraws.LineEndPropertiesType? GetTailEnd(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.TailEnd>();
    if (element != null)
      return DMXDraws.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXDraw.Underline openXmlElement, DMDraws.LineEndPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TailEnd>(), value, diffs, objName);
  }
  
  private static void SetTailEnd(DXDraw.Underline openXmlElement, DMDraws.LineEndPropertiesType? value)
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
  
  private static DMDraws.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXDraw.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LinePropertiesExtensionList>();
    if (element != null)
      return DMXDraws.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXDraw.Underline openXmlElement, DMDraws.LinePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LinePropertiesExtensionList>(), value, diffs, objName);
  }
  
  private static void SetLinePropertiesExtensionList(DXDraw.Underline openXmlElement, DMDraws.LinePropertiesExtensionList? value)
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
  
  public static DocumentModel.Drawings.Underline? CreateModelElement(DXDraw.Underline? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.Underline? openXmlElement, DMDraws.Underline? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Underline value)
    where OpenXmlElementType: DXDraw.Underline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Underline openXmlElement, DMDraws.Underline value)
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
