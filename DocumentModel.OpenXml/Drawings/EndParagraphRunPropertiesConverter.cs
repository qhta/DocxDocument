namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// End Paragraph Run Properties.
/// </summary>
public static class EndParagraphRunPropertiesConverter
{
  private static DMD.LineProperties? GetOutline(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXD.EndParagraphRunProperties openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName, propName);
  }
  
  private static void SetOutline(DXD.EndParagraphRunProperties openXmlElement, DMD.LineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Outline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectList? GetEffectList(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXD.EndParagraphRunProperties openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXD.EndParagraphRunProperties openXmlElement, DMD.EffectList? value)
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
  
  private static DMD.EffectDag? GetEffectDag(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXD.EndParagraphRunProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXD.EndParagraphRunProperties openXmlElement, DMD.EffectDag? value)
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
  
  private static DMD.Highlight? GetHighlight(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Highlight>();
    if (element != null)
      return DMXD.HighlightConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighlight(DXD.EndParagraphRunProperties openXmlElement, DMD.Highlight? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HighlightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Highlight>(), value, diffs, objName, propName);
  }
  
  private static void SetHighlight(DXD.EndParagraphRunProperties openXmlElement, DMD.Highlight? value)
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
  
  private static Boolean? GetUnderlineFollowsText(DXD.EndParagraphRunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
  }
  
  private static bool CmpUnderlineFollowsText(DXD.EndParagraphRunProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFollowsText", val, value);
    return false;
  }
  
  private static void SetUnderlineFollowsText(DXD.EndParagraphRunProperties openXmlElement, Boolean? value)
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
  
  private static DMD.LineProperties? GetUnderline(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Underline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderline(DXD.EndParagraphRunProperties openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Underline>(), value, diffs, objName, propName);
  }
  
  private static void SetUnderline(DXD.EndParagraphRunProperties openXmlElement, DMD.LineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Underline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFillText(DXD.EndParagraphRunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
  }
  
  private static bool CmpUnderlineFillText(DXD.EndParagraphRunProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFillText", val, value);
    return false;
  }
  
  private static void SetUnderlineFillText(DXD.EndParagraphRunProperties openXmlElement, Boolean? value)
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
  
  private static DMD.Fill? GetUnderlineFill(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UnderlineFill>();
    if (element != null)
      return DMXD.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderlineFill(DXD.EndParagraphRunProperties openXmlElement, DMD.Fill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UnderlineFill>(), value, diffs, objName, propName);
  }
  
  private static void SetUnderlineFill(DXD.EndParagraphRunProperties openXmlElement, DMD.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillConverter.CreateOpenXmlElement<DXD.UnderlineFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetLatinFont(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LatinFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLatinFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), value, diffs, objName, propName);
  }
  
  private static void SetLatinFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetEastAsianFont(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EastAsianFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEastAsianFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetComplexScriptFont(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ComplexScriptFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComplexScriptFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), value, diffs, objName, propName);
  }
  
  private static void SetComplexScriptFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetSymbolFont(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SymbolFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSymbolFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SymbolFont>(), value, diffs, objName, propName);
  }
  
  private static void SetSymbolFont(DXD.EndParagraphRunProperties openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.HyperlinkOnClick? GetHyperlinkOnClick(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnClick>();
    if (element != null)
      return DMXD.HyperlinkOnClickConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnClick(DXD.EndParagraphRunProperties openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnClick(DXD.EndParagraphRunProperties openXmlElement, DMD.HyperlinkOnClick? value)
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
  
  private static DMD.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnMouseOver>();
    if (element != null)
      return DMXD.HyperlinkOnMouseOverConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnMouseOver(DXD.EndParagraphRunProperties openXmlElement, DMD.HyperlinkOnMouseOver? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnMouseOver(DXD.EndParagraphRunProperties openXmlElement, DMD.HyperlinkOnMouseOver? value)
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
  
  private static Boolean? GetRightToLeft(DXD.EndParagraphRunProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
  }
  
  private static bool CmpRightToLeft(DXD.EndParagraphRunProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.RightToLeft", val, value);
    return false;
  }
  
  private static void SetRightToLeft(DXD.EndParagraphRunProperties openXmlElement, Boolean? value)
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
  
  private static DMD.ExtensionList? GetExtensionList(DXD.EndParagraphRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.EndParagraphRunProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.EndParagraphRunProperties openXmlElement, DMD.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.EndParagraphRunProperties? CreateModelElement(DXD.EndParagraphRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DocumentModel.Drawings.EndParagraphRunProperties();
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
      model.ExtensionList = GetExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.EndParagraphRunProperties? openXmlElement, DMD.EndParagraphRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpOutline(openXmlElement, model.Outline, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareModelElement(openXmlElement, model.Fill, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EndParagraphRunProperties model)
    where OpenXmlElementType: DXD.EndParagraphRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EndParagraphRunProperties openXmlElement, DMD.EndParagraphRunProperties model)
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
