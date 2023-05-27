namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public static class OutlineConverter
{
  
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
  
  public static DMD.Outline? CreateModelElement(DXD.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.Outline();
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
  
  public static bool CompareModelElement(DXD.Outline? openXmlElement, DMD.Outline? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!FillConverter.CompareModelElement(openXmlElement, model.Fill, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Outline model)
    where OpenXmlElementType: DXD.Outline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Outline openXmlElement, DMD.Outline model)
  {
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
