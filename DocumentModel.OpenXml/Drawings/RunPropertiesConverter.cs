namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  public static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.NoFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SolidFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PatternFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.GroupFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EffectListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectDag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Highlight? GetHighlight(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HighlightConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHighlight(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.Highlight? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HighlightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Highlight>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUnderlineFollowsText(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFollowsText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUnderlineFollowsText(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFollowsText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.UnderlineFollowsText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Underline? GetUnderline(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Underline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.Underline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Underline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.UnderlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Underline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetUnderlineFillText(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFillText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetUnderlineFillText(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFillText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.UnderlineFillText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.UnderlineFill? GetUnderlineFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.UnderlineFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnderlineFill(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.UnderlineFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.UnderlineFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.UnderlineFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetLatinFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLatinFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LatinFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetEastAsianFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EastAsianFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetComplexScriptFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetComplexScriptFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetSymbolFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SymbolFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSymbolFont(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SymbolFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SymbolFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkOnClick? GetHyperlinkOnClick(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkOnClick(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.HyperlinkOnClick? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkOnClickConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnMouseOverConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkOnMouseOver(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.HyperlinkOnMouseOver? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetRightToLeft(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RightToLeft>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRightToLeft(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RightToLeft>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.RightToLeft();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.RunProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.RunProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RunProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.RunProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
