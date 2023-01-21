namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Default Text Run Properties.
/// </summary>
public static class DefaultRunPropertiesConverter
{
  private static DMDraws.Outline? GetOutline(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      return DMXDraws.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOutline(DXDraw.DefaultRunProperties openXmlElement, DMDraws.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OutlineConverter.CreateOpenXmlElement<DXDraw.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DXDraw.DefaultRunProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.SolidFill? GetSolidFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DXDraw.DefaultRunProperties openXmlElement, DMDraws.SolidFill? value)
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
  
  private static DMDraws.GradientFill? GetGradientFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DXDraw.DefaultRunProperties openXmlElement, DMDraws.GradientFill? value)
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
  
  private static DMDraws.BlipFill? GetBlipFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      return DMXDraws.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DXDraw.DefaultRunProperties openXmlElement, DMDraws.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipFillConverter.CreateOpenXmlElement<DXDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PatternFill? GetPatternFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DXDraw.DefaultRunProperties openXmlElement, DMDraws.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
    return itemElement != null;
  }
  
  private static void SetGroupFill(DXDraw.DefaultRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectList? GetEffectList(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      return DMXDraws.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectList(DXDraw.DefaultRunProperties openXmlElement, DMDraws.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectListConverter.CreateOpenXmlElement<DXDraw.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectDag? GetEffectDag(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectDag(DXDraw.DefaultRunProperties openXmlElement, DMDraws.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectDagConverter.CreateOpenXmlElement<DXDraw.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Highlight? GetHighlight(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Highlight>();
    if (itemElement != null)
      return DMXDraws.HighlightConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHighlight(DXDraw.DefaultRunProperties openXmlElement, DMDraws.Highlight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HighlightConverter.CreateOpenXmlElement<DXDraw.Highlight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFollowsText(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFollowsText>();
    return itemElement != null;
  }
  
  private static void SetUnderlineFollowsText(DXDraw.DefaultRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFollowsText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.UnderlineFollowsText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Underline? GetUnderline(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Underline>();
    if (itemElement != null)
      return DMXDraws.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnderline(DXDraw.DefaultRunProperties openXmlElement, DMDraws.Underline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.UnderlineConverter.CreateOpenXmlElement<DXDraw.Underline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUnderlineFillText(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFillText>();
    return itemElement != null;
  }
  
  private static void SetUnderlineFillText(DXDraw.DefaultRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFillText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.UnderlineFillText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.UnderlineFill? GetUnderlineFill(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.UnderlineFill>();
    if (itemElement != null)
      return DMXDraws.UnderlineFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnderlineFill(DXDraw.DefaultRunProperties openXmlElement, DMDraws.UnderlineFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.UnderlineFillConverter.CreateOpenXmlElement<DXDraw.UnderlineFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetLatinFont(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLatinFont(DXDraw.DefaultRunProperties openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.LatinFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetEastAsianFont(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEastAsianFont(DXDraw.DefaultRunProperties openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.EastAsianFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetComplexScriptFont(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetComplexScriptFont(DXDraw.DefaultRunProperties openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.ComplexScriptFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetSymbolFont(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SymbolFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSymbolFont(DXDraw.DefaultRunProperties openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SymbolFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.SymbolFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnClick(DXDraw.DefaultRunProperties openXmlElement, DMDraws.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnClickConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnMouseOver>();
    if (itemElement != null)
      return DMXDraws.HyperlinkOnMouseOverConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnMouseOver(DXDraw.DefaultRunProperties openXmlElement, DMDraws.HyperlinkOnMouseOver? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnMouseOver>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnMouseOver>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRightToLeft(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RightToLeft>();
    return itemElement != null;
  }
  
  private static void SetRightToLeft(DXDraw.DefaultRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.RightToLeft>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.RightToLeft();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.DefaultRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.DefaultRunProperties openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.DefaultRunProperties? CreateModelElement(DXDraw.DefaultRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.DefaultRunProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.DefaultRunProperties? value)
    where OpenXmlElementType: DXDraw.DefaultRunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
