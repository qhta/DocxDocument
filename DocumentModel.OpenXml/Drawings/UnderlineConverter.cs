namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Underline Stroke.
/// </summary>
public static class UnderlineConverter
{
  private static DMD.PresetLineDashKind? GetPresetDash(DXD.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value);
  }
  
  private static bool CmpPresetDash(DXD.Underline openXmlElement, DMD.PresetLineDashKind? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(openXmlElement.GetFirstChild<DXD.PresetDash>()?.Val?.Value, model, diffs, objName, propName);
  }
  
  private static void SetPresetDash(DXD.Underline openXmlElement, DMD.PresetLineDashKind? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetDash>();
    if (itemElement != null)
    {
      if (model != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>(itemElement, (DMD.PresetLineDashKind)model);
      else
        itemElement.Remove();
    }
    else
    if (model != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXD.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DMD.PresetLineDashKind>((DMD.PresetLineDashKind)model));
  }
  
  private static DMD.CustomDash? GetCustomDash(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomDash>();
    if (element != null)
      return DMXD.CustomDashConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomDash(DXD.Underline openXmlElement, DMD.CustomDash? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomDashConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomDash>(), model, diffs, objName, propName);
  }
  
  private static void SetCustomDash(DXD.Underline openXmlElement, DMD.CustomDash? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomDash>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.CustomDashConverter.CreateOpenXmlElement<DXD.CustomDash>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetRound(DXD.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Round>() != null;
  }
  
  private static bool CmpRound(DXD.Underline openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Round>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.Round", val, model);
    return false;
  }
  
  private static void SetRound(DXD.Underline openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Round>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
    {
      var itemElement = new DXD.Round();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetLineJoinBevel(DXD.Underline openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
  }
  
  private static bool CmpLineJoinBevel(DXD.Underline openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.LineJoinBevel>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.LineJoinBevel", val, model);
    return false;
  }
  
  private static void SetLineJoinBevel(DXD.Underline openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.LineJoinBevel>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
    {
      var itemElement = new DXD.LineJoinBevel();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Miter? GetMiter(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Miter>();
    if (element != null)
      return DMXD.MiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMiter(DXD.Underline openXmlElement, DMD.Miter? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.MiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Miter>(), model, diffs, objName, propName);
  }
  
  private static void SetMiter(DXD.Underline openXmlElement, DMD.Miter? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Miter>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.MiterConverter.CreateOpenXmlElement<DXD.Miter>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetHeadEnd(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HeadEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HeadEnd>(), model, diffs, objName, propName);
  }
  
  private static void SetHeadEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HeadEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.HeadEnd>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineEndPropertiesType? GetTailEnd(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TailEnd>();
    if (element != null)
      return DMXD.LineEndPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTailEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineEndPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TailEnd>(), model, diffs, objName, propName);
  }
  
  private static void SetTailEnd(DXD.Underline openXmlElement, DMD.LineEndPropertiesType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TailEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DXD.TailEnd>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DXD.Underline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (element != null)
      return DMXD.LinePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinePropertiesExtensionList(DXD.Underline openXmlElement, DMD.LinePropertiesExtensionList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>(), model, diffs, objName, propName);
  }
  
  private static void SetLinePropertiesExtensionList(DXD.Underline openXmlElement, DMD.LinePropertiesExtensionList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LinePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.LinePropertiesExtensionList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Underline? CreateModelElement(DXD.Underline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DocumentModel.Drawings.Underline();
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
  
  public static bool CompareModelElement(DXD.Underline? openXmlElement, DMD.Underline? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Underline model)
    where OpenXmlElementType: DXD.Underline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Underline openXmlElement, DMD.Underline model)
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
