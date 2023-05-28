namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  private static DMD.LineProperties? GetOutline(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXD.RunProperties openXmlElement, DMD.LineProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), model, diffs, objName, propName);
  }
  
  private static void SetOutline(DXD.RunProperties openXmlElement, DMD.LineProperties? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Outline>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXD.RunProperties openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.NoFill", val, model);
    return false;
  }
  
  private static void SetNoFill(DXD.RunProperties openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
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
  
  private static bool CmpSolidFill(DXD.RunProperties openXmlElement, DMD.SolidFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), model, diffs, objName, propName);
  }
  
  private static void SetSolidFill(DXD.RunProperties openXmlElement, DMD.SolidFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement(model);
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
  
  private static bool CmpGradientFill(DXD.RunProperties openXmlElement, DMD.GradientFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), model, diffs, objName, propName);
  }
  
  private static void SetGradientFill(DXD.RunProperties openXmlElement, DMD.GradientFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement(model);
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
  
  private static bool CmpBlipFill(DXD.RunProperties openXmlElement, DMD.BlipFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipFill>(), model, diffs, objName, propName);
  }
  
  private static void SetBlipFill(DXD.RunProperties openXmlElement, DMD.BlipFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.BlipFillConverter.CreateOpenXmlElement(model);
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
  
  private static bool CmpPatternFill(DXD.RunProperties openXmlElement, DMD.PatternFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), model, diffs, objName, propName);
  }
  
  private static void SetPatternFill(DXD.RunProperties openXmlElement, DMD.PatternFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetGroupFill(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXD.RunProperties openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.GroupFill", val, model);
    return false;
  }
  
  private static void SetGroupFill(DXD.RunProperties openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
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
  
  private static bool CmpEffectList(DXD.RunProperties openXmlElement, DMD.EffectList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXD.RunProperties openXmlElement, DMD.EffectList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(model);
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
  
  private static bool CmpEffectDag(DXD.RunProperties openXmlElement, DMD.EffectDag? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXD.RunProperties openXmlElement, DMD.EffectDag? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(model);
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
  
  private static bool CmpHighlight(DXD.RunProperties openXmlElement, DMD.Highlight? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HighlightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Highlight>(), model, diffs, objName, propName);
  }
  
  private static void SetHighlight(DXD.RunProperties openXmlElement, DMD.Highlight? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.HighlightConverter.CreateOpenXmlElement<DXD.Highlight>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFollowsText(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
  }
  
  private static bool CmpUnderlineFollowsText(DXD.RunProperties openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.UnderlineFollowsText", val, model);
    return false;
  }
  
  private static void SetUnderlineFollowsText(DXD.RunProperties openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
    {
      var itemElement = new DXD.UnderlineFollowsText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineProperties? GetUnderline(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Underline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderline(DXD.RunProperties openXmlElement, DMD.LineProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Underline>(), model, diffs, objName, propName);
  }
  
  private static void SetUnderline(DXD.RunProperties openXmlElement, DMD.LineProperties? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Underline>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFillText(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
  }
  
  private static bool CmpUnderlineFillText(DXD.RunProperties openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.UnderlineFillText", val, model);
    return false;
  }
  
  private static void SetUnderlineFillText(DXD.RunProperties openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFillText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
    {
      var itemElement = new DXD.UnderlineFillText();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Fill? GetUnderlineFill(DXD.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UnderlineFill>();
    if (element != null)
      return DMXD.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderlineFill(DXD.RunProperties openXmlElement, DMD.Fill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UnderlineFill>(), model, diffs, objName, propName);
  }
  
  private static void SetUnderlineFill(DXD.RunProperties openXmlElement, DMD.Fill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.FillConverter.CreateOpenXmlElement<DXD.UnderlineFill>(model);
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
  
  private static bool CmpLatinFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), model, diffs, objName, propName);
  }
  
  private static void SetLatinFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.LatinFont>(model);
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
  
  private static bool CmpEastAsianFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), model, diffs, objName, propName);
  }
  
  private static void SetEastAsianFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.EastAsianFont>(model);
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
  
  private static bool CmpComplexScriptFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), model, diffs, objName, propName);
  }
  
  private static void SetComplexScriptFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.ComplexScriptFont>(model);
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
  
  private static bool CmpSymbolFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SymbolFont>(), model, diffs, objName, propName);
  }
  
  private static void SetSymbolFont(DXD.RunProperties openXmlElement, DMD.TextFontType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SymbolFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.SymbolFont>(model);
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
  
  private static bool CmpHyperlinkOnClick(DXD.RunProperties openXmlElement, DMD.HyperlinkOnClick? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), model, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnClick(DXD.RunProperties openXmlElement, DMD.HyperlinkOnClick? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.HyperlinkOnClickConverter.CreateOpenXmlElement<DXD.HyperlinkOnClick>(model);
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
  
  private static bool CmpHyperlinkOnMouseOver(DXD.RunProperties openXmlElement, DMD.HyperlinkOnMouseOver? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>(), model, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnMouseOver(DXD.RunProperties openXmlElement, DMD.HyperlinkOnMouseOver? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DXD.HyperlinkOnMouseOver>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetRightToLeft(DXD.RunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
  }
  
  private static bool CmpRightToLeft(DXD.RunProperties openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
    if (val == model) return true;
    diffs?.Add(objName, "DXD.RightToLeft", val, model);
    return false;
  }
  
  private static void SetRightToLeft(DXD.RunProperties openXmlElement, Boolean? model)
  {
    if (model == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.RightToLeft>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (model == true)
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
  
  private static bool CmpExtensionList(DXD.RunProperties openXmlElement, DMD.ExtensionList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), model, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.RunProperties openXmlElement, DMD.ExtensionList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.RunProperties? CreateModelElement(DXD.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.RunProperties();
      model.Outline = GetOutline(openXmlElement);
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      model.EffectList = GetEffectList(openXmlElement);
      model.EffectDag = GetEffectDag(openXmlElement);
      model.Highlight = GetHighlight(openXmlElement);
      model.UnderlineFollowsText = GetUnderlineFollowsText(openXmlElement);
      model.Underline = GetUnderline(openXmlElement);
      model.UnderlineFillText = GetUnderlineFillText(openXmlElement);
      model.UnderlineFill = GetUnderlineFill(openXmlElement);
      model.LatinFont = GetLatinFont(openXmlElement);
      model.EastAsianFont = GetEastAsianFont(openXmlElement);
      model.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      model.SymbolFont = GetSymbolFont(openXmlElement);
      model.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      model.HyperlinkOnMouseOver = GetHyperlinkOnMouseOver(openXmlElement);
      model.RightToLeft = GetRightToLeft(openXmlElement);
      //model.DrawingProperties = DrawingPropertiesConverter.CreateModelElement(openXmlElement);
      model.ExtensionList = GetExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.RunProperties? openXmlElement, DMD.RunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpOutline(openXmlElement, model.Outline, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpEffectList(openXmlElement, model.EffectList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, model.EffectDag, diffs, objName, propName))
        ok = false;
      if (!CmpHighlight(openXmlElement, model.Highlight, diffs, objName, propName))
        ok = false;
      if (!CmpUnderlineFollowsText(openXmlElement, model.UnderlineFollowsText, diffs, objName, propName))
        ok = false;
      if (!CmpUnderline(openXmlElement, model.Underline, diffs, objName, propName))
        ok = false;
      if (!CmpUnderlineFillText(openXmlElement, model.UnderlineFillText, diffs, objName, propName))
        ok = false;
      if (!CmpUnderlineFill(openXmlElement, model.UnderlineFill, diffs, objName, propName))
        ok = false;
      if (!CmpLatinFont(openXmlElement, model.LatinFont, diffs, objName, propName))
        ok = false;
      if (!CmpEastAsianFont(openXmlElement, model.EastAsianFont, diffs, objName, propName))
        ok = false;
      if (!CmpComplexScriptFont(openXmlElement, model.ComplexScriptFont, diffs, objName, propName))
        ok = false;
      if (!CmpSymbolFont(openXmlElement, model.SymbolFont, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, model.HyperlinkOnClick, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlinkOnMouseOver(openXmlElement, model.HyperlinkOnMouseOver, diffs, objName, propName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, model.RightToLeft, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, model.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.RunProperties model)
    where OpenXmlElementType: DXD.RunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.RunProperties openXmlElement, DMD.RunProperties model)
  {
    SetOutline(openXmlElement, model.Outline);
    FillConverter.UpdateOpenXmlElement(openXmlElement, model.Fill);
    SetEffectList(openXmlElement, model.EffectList);
    SetEffectDag(openXmlElement, model.EffectDag);
    SetHighlight(openXmlElement, model.Highlight);
    SetUnderlineFollowsText(openXmlElement, model.UnderlineFollowsText);
    SetUnderline(openXmlElement, model.Underline);
    SetUnderlineFillText(openXmlElement, model.UnderlineFillText);
    SetUnderlineFill(openXmlElement, model.UnderlineFill);
    SetLatinFont(openXmlElement, model.LatinFont);
    SetEastAsianFont(openXmlElement, model.EastAsianFont);
    SetComplexScriptFont(openXmlElement, model.ComplexScriptFont);
    SetSymbolFont(openXmlElement, model.SymbolFont);
    SetHyperlinkOnClick(openXmlElement, model.HyperlinkOnClick);
    SetHyperlinkOnMouseOver(openXmlElement, model.HyperlinkOnMouseOver);
    SetRightToLeft(openXmlElement, model.RightToLeft);
    SetExtensionList(openXmlElement, model.ExtensionList);
  }
}
