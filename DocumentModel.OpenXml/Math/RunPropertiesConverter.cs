namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.RunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class RunPropertiesConverter
{
  #region Literal. conversion.
  private static bool? GetLiteral(DXM.RunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.Literal>()?.Val?.Value);
  }
  
  private static bool CmpLiteral(DXM.RunProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.Literal>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLiteral(DXM.RunProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Literal>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.Literal>((bool)value));
  }
  
  private static bool? GetNormalText(DXM.RunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.NormalText>()?.Val?.Value);
  }
  
  private static bool CmpNormalText(DXM.RunProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.NormalText>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetNormalText(DXM.RunProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.NormalText>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.NormalText>((bool)value));
  }
  
  private static DMM.ScriptKind? GetScript(DXM.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>(openXmlElement.GetFirstChild<DXM.Script>()?.Val?.Value);
  }
  
  private static bool CmpScript(DXM.RunProperties openXmlElement, DMM.ScriptKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>(openXmlElement.GetFirstChild<DXM.Script>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetScript(DXM.RunProperties openXmlElement, DMM.ScriptKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Script>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>(itemElement, (DMM.ScriptKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.Script, DocumentFormat.OpenXml.Math.ScriptValues, DMM.ScriptKind>((DMM.ScriptKind)value));
  }
  
  private static DMM.StyleKind? GetStyle(DXM.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>(openXmlElement.GetFirstChild<DXM.Style>()?.Val?.Value);
  }
  
  private static bool CmpStyle(DXM.RunProperties openXmlElement, DMM.StyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>(openXmlElement.GetFirstChild<DXM.Style>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStyle(DXM.RunProperties openXmlElement, DMM.StyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Style>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>(itemElement, (DMM.StyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.Style, DocumentFormat.OpenXml.Math.StyleValues, DMM.StyleKind>((DMM.StyleKind)value));
  }
  
  private static DMM.Break? GetBreak(DXM.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Break>();
    if (element != null)
      return DMXM.BreakConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBreak(DXM.RunProperties openXmlElement, DMM.Break? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Break>(), value, diffs, objName, propName);
  }
  
  private static void SetBreak(DXM.RunProperties openXmlElement, DMM.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BreakConverter.CreateOpenXmlElement<DXM.Break>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static bool? GetAlignment(DXM.RunProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.Alignment>()?.Val?.Value);
  }
  
  private static bool CmpAlignment(DXM.RunProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.Alignment>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXM.RunProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Alignment>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.Alignment>((bool)value));
  }
  #endregion

  #region RunProperties model conversion.
  public static DMM.RunProperties? CreateModelElement(DXM.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.RunProperties();
      model.Literal = GetLiteral(openXmlElement);
      model.NormalText = GetNormalText(openXmlElement);
      model.Script = GetScript(openXmlElement);
      model.Style = GetStyle(openXmlElement);
      model.Break = GetBreak(openXmlElement);
      model.Alignment = GetAlignment(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.RunProperties? openXmlElement, DMM.RunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLiteral(openXmlElement, model.Literal, diffs, objName, propName))
        ok = false;
      if (!CmpNormalText(openXmlElement, model.NormalText, diffs, objName, propName))
        ok = false;
      if (!CmpScript(openXmlElement, model.Script, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, model.Style, diffs, objName, propName))
        ok = false;
      if (!CmpBreak(openXmlElement, model.Break, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, model.Alignment, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.RunProperties model)
    where OpenXmlElementType: DXM.RunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.RunProperties openXmlElement, DMM.RunProperties model)
  {
    SetLiteral(openXmlElement, model?.Literal);
    SetNormalText(openXmlElement, model?.NormalText);
    SetScript(openXmlElement, model?.Script);
    SetStyle(openXmlElement, model?.Style);
    SetBreak(openXmlElement, model?.Break);
    SetAlignment(openXmlElement, model?.Alignment);
  }
  #endregion
}
