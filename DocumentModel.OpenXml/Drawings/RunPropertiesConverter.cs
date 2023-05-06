namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  private static DMD.Outline? GetOutline(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXD.RunProperties openXmlElement, DMD.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXD.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName);
  }
  
  private static void SetOutline(DXD.RunProperties openXmlElement, DMD.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXD.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXD.RunProperties openXmlElement, Boolean? value)
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
  
  private static DMD.SolidFill? GetSolidFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXD.RunProperties openXmlElement, DMD.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXD.RunProperties openXmlElement, DMD.SolidFill? value)
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
  
  private static DMD.GradientFill? GetGradientFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXD.RunProperties openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXD.RunProperties openXmlElement, DMD.GradientFill? value)
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
  
  private static DMD.BlipFill? GetBlipFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipFill>();
    if (element != null)
      return DMXD.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXD.RunProperties openXmlElement, DMD.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipFill>(), value, diffs, objName);
  }
  
  private static void SetBlipFill(DXD.RunProperties openXmlElement, DMD.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXD.RunProperties openXmlElement, DMD.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXD.RunProperties openXmlElement, DMD.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXD.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXD.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.GroupFill();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectList? GetEffectList(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXD.RunProperties openXmlElement, DMD.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName);
  }
  
  private static void SetEffectList(DXD.RunProperties openXmlElement, DMD.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXD.RunProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName);
  }
  
  private static void SetEffectDag(DXD.RunProperties openXmlElement, DMD.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Highlight? GetHighlight(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Highlight>();
    if (element != null)
      return DMXD.HighlightConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighlight(DXD.RunProperties openXmlElement, DMD.Highlight? value, DiffList? diffs, string? objName)
  {
    return DMXD.HighlightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Highlight>(), value, diffs, objName);
  }
  
  private static void SetHighlight(DXD.RunProperties openXmlElement, DMD.Highlight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HighlightConverter.CreateOpenXmlElement<DXD.Highlight>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFollowsText(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
  }
  
  private static bool CmpUnderlineFollowsText(DXD.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFollowsText", val, value);
    return false;
  }
  
  private static void SetUnderlineFollowsText(DXD.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.UnderlineFollowsText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Underline? GetUnderline(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Underline>();
    if (element != null)
      return DMXD.UnderlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderline(DXD.RunProperties openXmlElement, DMD.Underline? value, DiffList? diffs, string? objName)
  {
    return DMXD.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Underline>(), value, diffs, objName);
  }
  
  private static void SetUnderline(DXD.RunProperties openXmlElement, DMD.Underline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.UnderlineConverter.CreateOpenXmlElement<DXD.Underline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFillText(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
  }
  
  private static bool CmpUnderlineFillText(DXD.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFillText", val, value);
    return false;
  }
  
  private static void SetUnderlineFillText(DXD.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFillText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.UnderlineFillText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.UnderlineFill? GetUnderlineFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UnderlineFill>();
    if (element != null)
      return DMXD.UnderlineFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderlineFill(DXD.RunProperties openXmlElement, DMD.UnderlineFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.UnderlineFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UnderlineFill>(), value, diffs, objName);
  }
  
  private static void SetUnderlineFill(DXD.RunProperties openXmlElement, DMD.UnderlineFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.UnderlineFillConverter.CreateOpenXmlElement<DXD.UnderlineFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetLatinFont(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LatinFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLatinFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), value, diffs, objName);
  }
  
  private static void SetLatinFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.LatinFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetEastAsianFont(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EastAsianFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), value, diffs, objName);
  }
  
  private static void SetEastAsianFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.EastAsianFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetComplexScriptFont(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ComplexScriptFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComplexScriptFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), value, diffs, objName);
  }
  
  private static void SetComplexScriptFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.ComplexScriptFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetSymbolFont(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SymbolFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSymbolFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SymbolFont>(), value, diffs, objName);
  }
  
  private static void SetSymbolFont(DXD.RunProperties openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SymbolFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.SymbolFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HyperlinkOnClick? GetHyperlinkOnClick(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnClick>();
    if (element != null)
      return DMXD.HyperlinkOnClickConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnClick(DXD.RunProperties openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkOnClick(DXD.RunProperties openXmlElement, DMD.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkOnClickConverter.CreateOpenXmlElement<DXD.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnMouseOver>();
    if (element != null)
      return DMXD.HyperlinkOnMouseOverConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnMouseOver(DXD.RunProperties openXmlElement, DMD.HyperlinkOnMouseOver? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>(), value, diffs, objName);
  }
  
  private static void SetHyperlinkOnMouseOver(DXD.RunProperties openXmlElement, DMD.HyperlinkOnMouseOver? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DXD.HyperlinkOnMouseOver>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetRightToLeft(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
  }
  
  private static bool CmpRightToLeft(DXD.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.RightToLeft", val, value);
    return false;
  }
  
  private static void SetRightToLeft(DXD.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.RightToLeft>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.RightToLeft();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.RunProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXD.RunProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.RunProperties? CreateModelElement(DXD.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RunProperties();
      value.Outline = GetOutline(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Highlight = GetHighlight(openXmlElement);
      value.UnderlineFollowsText = GetUnderlineFollowsText(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.UnderlineFillText = GetUnderlineFillText(openXmlElement);
      value.UnderlineFill = GetUnderlineFill(openXmlElement);
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SymbolFont = GetSymbolFont(openXmlElement);
      value.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      value.HyperlinkOnMouseOver = GetHyperlinkOnMouseOver(openXmlElement);
      value.RightToLeft = GetRightToLeft(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.RunProperties? openXmlElement, DMD.RunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpGroupFill(openXmlElement, value.GroupFill, diffs, objName))
        ok = false;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
        ok = false;
      if (!CmpUnderlineFollowsText(openXmlElement, value.UnderlineFollowsText, diffs, objName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName))
        ok = false;
      if (!CmpUnderlineFillText(openXmlElement, value.UnderlineFillText, diffs, objName))
        ok = false;
      if (!CmpUnderlineFill(openXmlElement, value.UnderlineFill, diffs, objName))
        ok = false;
      if (!CmpLatinFont(openXmlElement, value.LatinFont, diffs, objName))
        ok = false;
      if (!CmpEastAsianFont(openXmlElement, value.EastAsianFont, diffs, objName))
        ok = false;
      if (!CmpComplexScriptFont(openXmlElement, value.ComplexScriptFont, diffs, objName))
        ok = false;
      if (!CmpSymbolFont(openXmlElement, value.SymbolFont, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, value.HyperlinkOnClick, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnMouseOver(openXmlElement, value.HyperlinkOnMouseOver, diffs, objName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, value.RightToLeft, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.RunProperties value)
    where OpenXmlElementType: DXD.RunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.RunProperties openXmlElement, DMD.RunProperties value)
  {
    SetOutline(openXmlElement, value?.Outline);
    SetNoFill(openXmlElement, value?.NoFill);
    SetSolidFill(openXmlElement, value?.SolidFill);
    SetGradientFill(openXmlElement, value?.GradientFill);
    SetBlipFill(openXmlElement, value?.BlipFill);
    SetPatternFill(openXmlElement, value?.PatternFill);
    SetGroupFill(openXmlElement, value?.GroupFill);
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
    SetHighlight(openXmlElement, value?.Highlight);
    SetUnderlineFollowsText(openXmlElement, value?.UnderlineFollowsText);
    SetUnderline(openXmlElement, value?.Underline);
    SetUnderlineFillText(openXmlElement, value?.UnderlineFillText);
    SetUnderlineFill(openXmlElement, value?.UnderlineFill);
    SetLatinFont(openXmlElement, value?.LatinFont);
    SetEastAsianFont(openXmlElement, value?.EastAsianFont);
    SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
    SetSymbolFont(openXmlElement, value?.SymbolFont);
    SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
    SetHyperlinkOnMouseOver(openXmlElement, value?.HyperlinkOnMouseOver);
    SetRightToLeft(openXmlElement, value?.RightToLeft);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
