namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  public static String? GetRunStyle(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.RunStyle");
  }
  
  public static void SetRunStyle(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.RunStyle");
  }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunFonts? GetRunFonts(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunFonts(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.RunFonts? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public static Boolean? GetBold(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Bold>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBold(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public static Boolean? GetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public static Boolean? GetItalic(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Italic>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalic(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public static Boolean? GetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public static Boolean? GetCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public static Boolean? GetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public static Boolean? GetStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Strike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public static Boolean? GetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public static Boolean? GetOutline(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Outline>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public static Boolean? GetShadow(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shadow>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public static Boolean? GetEmboss(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emboss>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEmboss(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public static Boolean? GetImprint(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Imprint>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetImprint(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public static Boolean? GetNoProof(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoProof>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoProof(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public static Boolean? GetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public static Boolean? GetVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Vanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public static Boolean? GetWebHidden(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWebHidden(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  public static DocumentModel.Wordprocessing.Color? GetColor(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Color? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public static Int32? GetSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Spacing");
  }
  
  public static void SetSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Spacing");
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public static Int64? GetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CharacterScale");
  }
  
  public static void SetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CharacterScale");
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public static UInt32? GetKern(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Kern");
  }
  
  public static void SetKern(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Kern");
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Position");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Position");
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public static String? GetFontSize(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSize");
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSize");
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public static String? GetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript");
  }
  
  public static void SetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript");
  }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  public static DocumentModel.Wordprocessing.HighlightColorKind? GetHighlight(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Highlight>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DocumentModel.Wordprocessing.HighlightColorKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHighlight(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.HighlightColorKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public static DocumentModel.Wordprocessing.Underline? GetUnderline(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Underline? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public static DocumentModel.Wordprocessing.TextEffectKind? GetTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DocumentModel.Wordprocessing.TextEffectKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.TextEffectKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Border.
  /// </summary>
  public static DocumentModel.Wordprocessing.BorderType? GetBorder(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Border>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBorder(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public static DocumentModel.Wordprocessing.FitText? GetFitText(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FitTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFitText(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.FitText? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalPositionKind? GetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DocumentModel.Wordprocessing.VerticalPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalPositionKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public static Boolean? GetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public static Boolean? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public static DocumentModel.Wordprocessing.EmphasisMarkKind? GetEmphasis(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DocumentModel.Wordprocessing.EmphasisMarkKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetEmphasis(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.EmphasisMarkKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public static DocumentModel.Wordprocessing.LanguageType? GetLanguages(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Languages>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLanguages(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public static DocumentModel.Wordprocessing.EastAsianLayout? GetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.EastAsianLayout? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public static Boolean? GetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.Glow? GetGlow(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Glow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGlow(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Glow? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.Shadow2? GetShadow14(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Shadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Shadow2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShadow14(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Shadow2? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.Reflection? GetReflection(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Reflection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetReflection(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Reflection? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.TextOutlineEffect? GetTextOutlineEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextOutlineEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextOutlineEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.TextOutlineEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.FillTextEffect? GetFillTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillTextEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FillTextEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillTextEffect(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.FillTextEffect? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.Scene3D? GetScene3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Scene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScene3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Scene3D? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.Properties3D? GetProperties3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Properties3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Properties3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProperties3D(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.Properties3D? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.LigaturesKind? GetLigatures(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Ligatures>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DocumentModel.Wordprocessing.LigaturesKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLigatures(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.LigaturesKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberFormKind? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DocumentModel.Wordprocessing.NumberFormKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.NumberFormKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberSpacingKind? GetNumberSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DocumentModel.Wordprocessing.NumberSpacingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNumberSpacing(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.NumberSpacingKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.StylisticSets? GetStylisticSets(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.StylisticSets>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StylisticSetsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStylisticSets(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.StylisticSets? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffKind? GetContextualAlternatives(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetContextualAlternatives(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunPropertiesChange? GetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.RunProperties? openXmlElement, DocumentModel.Wordprocessing.RunPropertiesChange? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
