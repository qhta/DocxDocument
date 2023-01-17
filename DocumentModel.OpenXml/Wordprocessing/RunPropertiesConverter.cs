namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  private static String? GetRunStyle(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunStyle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRunStyle(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.RunStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  private static DocumentModel.Wordprocessing.RunFonts? GetRunFonts(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunFonts(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.RunFonts? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunFontsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunFonts>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bold.
  /// </summary>
  private static Boolean? GetBold(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Bold>();
    return itemElement != null;
  }
  
  private static void SetBold(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Bold>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Bold();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  private static Boolean? GetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
    return itemElement != null;
  }
  
  private static void SetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Italic.
  /// </summary>
  private static Boolean? GetItalic(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Italic>();
    return itemElement != null;
  }
  
  private static void SetItalic(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Italic>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Italic();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  private static Boolean? GetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
    return itemElement != null;
  }
  
  private static void SetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Caps.
  /// </summary>
  private static Boolean? GetCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caps>();
    return itemElement != null;
  }
  
  private static void SetCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Caps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  private static Boolean? GetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
    return itemElement != null;
  }
  
  private static void SetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SmallCaps();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Strike.
  /// </summary>
  private static Boolean? GetStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Strike>();
    return itemElement != null;
  }
  
  private static void SetStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Strike>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Strike();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  private static Boolean? GetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
    return itemElement != null;
  }
  
  private static void SetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoubleStrike();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static Boolean? GetOutline(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Outline>();
    return itemElement != null;
  }
  
  private static void SetOutline(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Outline>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Outline();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  private static Boolean? GetShadow(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shadow>();
    return itemElement != null;
  }
  
  private static void SetShadow(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Shadow();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  private static Boolean? GetEmboss(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emboss>();
    return itemElement != null;
  }
  
  private static void SetEmboss(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emboss>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Emboss();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  private static Boolean? GetImprint(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Imprint>();
    return itemElement != null;
  }
  
  private static void SetImprint(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Imprint>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Imprint();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  private static Boolean? GetNoProof(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoProof>();
    return itemElement != null;
  }
  
  private static void SetNoProof(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoProof>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.NoProof();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  private static Boolean? GetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
    return itemElement != null;
  }
  
  private static void SetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SnapToGrid();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  private static Boolean? GetVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Vanish>();
    return itemElement != null;
  }
  
  private static void SetVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Vanish>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Vanish();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  private static Boolean? GetWebHidden(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
    return itemElement != null;
  }
  
  private static void SetWebHidden(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.WebHidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  private static DocumentModel.Wordprocessing.Color? GetColor(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Color? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  private static Int32? GetSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Spacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Spacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  private static Int64? GetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.CharacterScale{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  private static UInt32? GetKern(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetKern(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kern>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Kern{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static String? GetPosition(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Position { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  private static String? GetFontSize(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFontSize(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.FontSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  private static String? GetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  private static DocumentModel.Wordprocessing.HighlightColorKind? GetHighlight(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Highlight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DocumentModel.Wordprocessing.HighlightColorKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHighlight(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.HighlightColorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Highlight, DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DocumentModel.Wordprocessing.HighlightColorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  private static DocumentModel.Wordprocessing.Underline? GetUnderline(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnderline(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Underline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.UnderlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Underline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  private static DocumentModel.Wordprocessing.TextEffectKind? GetTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DocumentModel.Wordprocessing.TextEffectKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.TextEffectKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextEffect, DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DocumentModel.Wordprocessing.TextEffectKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border.
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderType? GetBorder(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Border>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBorder(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Border>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Border>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FitText.
  /// </summary>
  private static DocumentModel.Wordprocessing.FitText? GetFitText(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FitTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFitText(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.FitText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FitTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FitText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  private static DocumentModel.Wordprocessing.VerticalPositionKind? GetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DocumentModel.Wordprocessing.VerticalPositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.VerticalPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DocumentModel.Wordprocessing.VerticalPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  private static Boolean? GetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
    return itemElement != null;
  }
  
  private static void SetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.RightToLeftText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  private static Boolean? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
    return itemElement != null;
  }
  
  private static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ComplexScript();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  private static DocumentModel.Wordprocessing.EmphasisMarkKind? GetEmphasis(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DocumentModel.Wordprocessing.EmphasisMarkKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetEmphasis(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.EmphasisMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Emphasis, DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DocumentModel.Wordprocessing.EmphasisMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Languages.
  /// </summary>
  private static DocumentModel.Wordprocessing.LanguageType? GetLanguages(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Languages>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLanguages(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Languages>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Languages>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  private static DocumentModel.Wordprocessing.EastAsianLayout? GetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.EastAsianLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.EastAsianLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  private static Boolean? GetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
    return itemElement != null;
  }
  
  private static void SetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SpecVanish();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.Glow? GetGlow(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGlow(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.Shadow2? GetShadow14(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Shadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Shadow2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShadow14(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Shadow2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Shadow2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.Reflection? GetReflection(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetReflection(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.TextOutlineEffect? GetTextOutlineEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextOutlineEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextOutlineEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.TextOutlineEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextOutlineEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.FillTextEffect? GetFillTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FillTextEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.FillTextEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FillTextEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.Scene3D? GetScene3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.Properties3D? GetProperties3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Properties3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProperties3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.Properties3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Properties3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Properties3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.LigaturesKind? GetLigatures(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Ligatures>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DocumentModel.Wordprocessing.LigaturesKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLigatures(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.LigaturesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Ligatures>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DocumentModel.Wordprocessing.LigaturesKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.NumberFormKind? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DocumentModel.Wordprocessing.NumberFormKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.NumberFormKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DocumentModel.Wordprocessing.NumberFormKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.NumberSpacingKind? GetNumberSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DocumentModel.Wordprocessing.NumberSpacingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNumberSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.NumberSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DocumentModel.Wordprocessing.NumberSpacingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.StylisticSets? GetStylisticSets(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StylisticSetsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStylisticSets(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.StylisticSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StylisticSetsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffKind? GetContextualAlternatives(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetContextualAlternatives(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  private static DocumentModel.Wordprocessing.RunPropertiesChange? GetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.RunProperties openXmlElement, DocumentModel.Wordprocessing.RunPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.RunProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunProperties();
      value.RunStyle = GetRunStyle(openXmlElement);
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
      value.Highlight = GetHighlight(openXmlElement);
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
      value.Glow = GetGlow(openXmlElement);
      value.Shadow14 = GetShadow14(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.TextOutlineEffect = GetTextOutlineEffect(openXmlElement);
      value.FillTextEffect = GetFillTextEffect(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Properties3D = GetProperties3D(openXmlElement);
      value.Ligatures = GetLigatures(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberSpacing = GetNumberSpacing(openXmlElement);
      value.StylisticSets = GetStylisticSets(openXmlElement);
      value.ContextualAlternatives = GetContextualAlternatives(openXmlElement);
      value.RunPropertiesChange = GetRunPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunStyle(openXmlElement, value?.RunStyle);
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
      SetHighlight(openXmlElement, value?.Highlight);
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
      SetGlow(openXmlElement, value?.Glow);
      SetShadow14(openXmlElement, value?.Shadow14);
      SetReflection(openXmlElement, value?.Reflection);
      SetTextOutlineEffect(openXmlElement, value?.TextOutlineEffect);
      SetFillTextEffect(openXmlElement, value?.FillTextEffect);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetProperties3D(openXmlElement, value?.Properties3D);
      SetLigatures(openXmlElement, value?.Ligatures);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberSpacing(openXmlElement, value?.NumberSpacing);
      SetStylisticSets(openXmlElement, value?.StylisticSets);
      SetContextualAlternatives(openXmlElement, value?.ContextualAlternatives);
      SetRunPropertiesChange(openXmlElement, value?.RunPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}
