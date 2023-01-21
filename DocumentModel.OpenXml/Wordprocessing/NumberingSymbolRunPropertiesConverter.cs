namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public static class NumberingSymbolRunPropertiesConverter
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  private static DMW.RunFonts? GetRunFonts(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunFonts>();
    if (itemElement != null)
      return DMXW.RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunFonts(DXW.NumberingSymbolRunProperties openXmlElement, DMW.RunFonts? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunFonts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunFontsConverter.CreateOpenXmlElement<DXW.RunFonts>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bold.
  /// </summary>
  private static Boolean? GetBold(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Bold>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBold(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Bold>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Bold();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  private static Boolean? GetBoldComplexScript(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BoldComplexScript>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBoldComplexScript(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BoldComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BoldComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Italic.
  /// </summary>
  private static Boolean? GetItalic(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Italic>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetItalic(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Italic>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Italic();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  private static Boolean? GetItalicComplexScript(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ItalicComplexScript>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetItalicComplexScript(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ItalicComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ItalicComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Caps.
  /// </summary>
  private static Boolean? GetCaps(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Caps>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetCaps(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Caps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Caps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  private static Boolean? GetSmallCaps(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SmallCaps>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSmallCaps(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SmallCaps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Strike.
  /// </summary>
  private static Boolean? GetStrike(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Strike>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetStrike(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Strike>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Strike();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  private static Boolean? GetDoubleStrike(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DoubleStrike>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoubleStrike(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoubleStrike>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoubleStrike();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static Boolean? GetOutline(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Outline>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetOutline(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Outline>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Outline();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  private static Boolean? GetShadow(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shadow>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetShadow(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Shadow();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  private static Boolean? GetEmboss(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Emboss>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetEmboss(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Emboss>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Emboss();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  private static Boolean? GetImprint(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Imprint>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetImprint(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Imprint>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Imprint();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  private static Boolean? GetNoProof(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoProof>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetNoProof(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.NoProof>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.NoProof();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  private static Boolean? GetSnapToGrid(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSnapToGrid(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SnapToGrid();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  private static Boolean? GetVanish(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Vanish>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetVanish(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Vanish>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Vanish();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  private static Boolean? GetWebHidden(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WebHidden>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetWebHidden(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WebHidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WebHidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  private static DMW.Color? GetColor(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      return DMXW.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColor(DXW.NumberingSymbolRunProperties openXmlElement, DMW.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  private static Int32? GetSpacing(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacing(DXW.NumberingSymbolRunProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Spacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Spacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  private static Int64? GetCharacterScale(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCharacterScale(DXW.NumberingSymbolRunProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CharacterScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.CharacterScale{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  private static UInt32? GetKern(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetKern(DXW.NumberingSymbolRunProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Kern>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Kern{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static String? GetPosition(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPosition(DXW.NumberingSymbolRunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Position { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  private static String? GetFontSize(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFontSize(DXW.NumberingSymbolRunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FontSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  private static String? GetFontSizeComplexScript(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFontSizeComplexScript(DXW.NumberingSymbolRunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FontSizeComplexScript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FontSizeComplexScript { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  private static DMW.Underline? GetUnderline(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Underline>();
    if (itemElement != null)
      return DMXW.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnderline(DXW.NumberingSymbolRunProperties openXmlElement, DMW.Underline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.UnderlineConverter.CreateOpenXmlElement<DXW.Underline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  private static DMW.TextEffectKind? GetTextEffect(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextEffect>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextEffect(DXW.NumberingSymbolRunProperties openXmlElement, DMW.TextEffectKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextEffect, DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border.
  /// </summary>
  private static DMW.BorderType? GetBorder(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Border>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBorder(DXW.NumberingSymbolRunProperties openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Border>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.Border>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      return DMXW.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DXW.NumberingSymbolRunProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FitText.
  /// </summary>
  private static DMW.FitText? GetFitText(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FitText>();
    if (itemElement != null)
      return DMXW.FitTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFitText(DXW.NumberingSymbolRunProperties openXmlElement, DMW.FitText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FitText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FitTextConverter.CreateOpenXmlElement<DXW.FitText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  private static DMW.VerticalPositionKind? GetVerticalTextAlignment(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalTextAlignment(DXW.NumberingSymbolRunProperties openXmlElement, DMW.VerticalPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  private static Boolean? GetRightToLeftText(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightToLeftText>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetRightToLeftText(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.RightToLeftText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.RightToLeftText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  private static Boolean? GetComplexScript(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ComplexScript>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetComplexScript(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  private static DMW.EmphasisMarkKind? GetEmphasis(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Emphasis>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetEmphasis(DXW.NumberingSymbolRunProperties openXmlElement, DMW.EmphasisMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Emphasis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Emphasis, DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Languages.
  /// </summary>
  private static DMW.LanguageType? GetLanguages(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Languages>();
    if (itemElement != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLanguages(DXW.NumberingSymbolRunProperties openXmlElement, DMW.LanguageType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Languages>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LanguageTypeConverter.CreateOpenXmlElement<DXW.Languages>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  private static DMW.EastAsianLayout? GetEastAsianLayout(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EastAsianLayout>();
    if (itemElement != null)
      return DMXW.EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEastAsianLayout(DXW.NumberingSymbolRunProperties openXmlElement, DMW.EastAsianLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EastAsianLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.EastAsianLayoutConverter.CreateOpenXmlElement<DXW.EastAsianLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  private static Boolean? GetSpecVanish(DXW.NumberingSymbolRunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SpecVanish>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetSpecVanish(DXW.NumberingSymbolRunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SpecVanish>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SpecVanish();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.NumberingSymbolRunProperties? CreateModelElement(DXW.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingSymbolRunProperties();
      value.RunFonts = GetRunFonts(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.BoldComplexScript = GetBoldComplexScript(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.ItalicComplexScript = GetItalicComplexScript(openXmlElement);
      value.Caps = GetCaps(openXmlElement);
      value.SmallCaps = GetSmallCaps(openXmlElement);
      value.Strike = GetStrike(openXmlElement);
      value.DoubleStrike = GetDoubleStrike(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Emboss = GetEmboss(openXmlElement);
      value.Imprint = GetImprint(openXmlElement);
      value.NoProof = GetNoProof(openXmlElement);
      value.SnapToGrid = GetSnapToGrid(openXmlElement);
      value.Vanish = GetVanish(openXmlElement);
      value.WebHidden = GetWebHidden(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Spacing = GetSpacing(openXmlElement);
      value.CharacterScale = GetCharacterScale(openXmlElement);
      value.Kern = GetKern(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.FontSizeComplexScript = GetFontSizeComplexScript(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.TextEffect = GetTextEffect(openXmlElement);
      value.Border = GetBorder(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.FitText = GetFitText(openXmlElement);
      value.VerticalTextAlignment = GetVerticalTextAlignment(openXmlElement);
      value.RightToLeftText = GetRightToLeftText(openXmlElement);
      value.ComplexScript = GetComplexScript(openXmlElement);
      value.Emphasis = GetEmphasis(openXmlElement);
      value.Languages = GetLanguages(openXmlElement);
      value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
      value.SpecVanish = GetSpecVanish(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingSymbolRunProperties? value)
    where OpenXmlElementType: DXW.NumberingSymbolRunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunFonts(openXmlElement, value?.RunFonts);
      SetBold(openXmlElement, value?.Bold);
      SetBoldComplexScript(openXmlElement, value?.BoldComplexScript);
      SetItalic(openXmlElement, value?.Italic);
      SetItalicComplexScript(openXmlElement, value?.ItalicComplexScript);
      SetCaps(openXmlElement, value?.Caps);
      SetSmallCaps(openXmlElement, value?.SmallCaps);
      SetStrike(openXmlElement, value?.Strike);
      SetDoubleStrike(openXmlElement, value?.DoubleStrike);
      SetOutline(openXmlElement, value?.Outline);
      SetShadow(openXmlElement, value?.Shadow);
      SetEmboss(openXmlElement, value?.Emboss);
      SetImprint(openXmlElement, value?.Imprint);
      SetNoProof(openXmlElement, value?.NoProof);
      SetSnapToGrid(openXmlElement, value?.SnapToGrid);
      SetVanish(openXmlElement, value?.Vanish);
      SetWebHidden(openXmlElement, value?.WebHidden);
      SetColor(openXmlElement, value?.Color);
      SetSpacing(openXmlElement, value?.Spacing);
      SetCharacterScale(openXmlElement, value?.CharacterScale);
      SetKern(openXmlElement, value?.Kern);
      SetPosition(openXmlElement, value?.Position);
      SetFontSize(openXmlElement, value?.FontSize);
      SetFontSizeComplexScript(openXmlElement, value?.FontSizeComplexScript);
      SetUnderline(openXmlElement, value?.Underline);
      SetTextEffect(openXmlElement, value?.TextEffect);
      SetBorder(openXmlElement, value?.Border);
      SetShading(openXmlElement, value?.Shading);
      SetFitText(openXmlElement, value?.FitText);
      SetVerticalTextAlignment(openXmlElement, value?.VerticalTextAlignment);
      SetRightToLeftText(openXmlElement, value?.RightToLeftText);
      SetComplexScript(openXmlElement, value?.ComplexScript);
      SetEmphasis(openXmlElement, value?.Emphasis);
      SetLanguages(openXmlElement, value?.Languages);
      SetEastAsianLayout(openXmlElement, value?.EastAsianLayout);
      SetSpecVanish(openXmlElement, value?.SpecVanish);
      return openXmlElement;
    }
    return default;
  }
}
