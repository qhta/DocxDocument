namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public static class NumberingSymbolRunPropertiesConverter
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunFonts? GetRunFonts(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunFonts(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.RunFonts? value)
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
  public static Boolean? GetBold(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Bold>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBold(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalic(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Italic>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalic(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetCaps(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetCaps(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetStrike(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Strike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetStrike(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetOutline(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Outline>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetShadow(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shadow>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetEmboss(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emboss>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEmboss(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetImprint(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Imprint>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetImprint(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoProof(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoProof>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoProof(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetVanish(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Vanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVanish(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetWebHidden(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWebHidden(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static DocumentModel.Wordprocessing.Color? GetColor(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.Color? value)
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
  public static Int32? GetSpacing(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Spacing");
  }
  
  public static void SetSpacing(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Spacing");
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public static Int64? GetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CharacterScale");
  }
  
  public static void SetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CharacterScale");
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public static UInt32? GetKern(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Kern");
  }
  
  public static void SetKern(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Kern");
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Position");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Position");
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public static String? GetFontSize(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSize");
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSize");
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public static String? GetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript");
  }
  
  public static void SetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript");
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public static DocumentModel.Wordprocessing.Underline? GetUnderline(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.Underline? value)
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
  public static DocumentModel.Wordprocessing.TextEffectKind? GetTextEffect(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
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
  
  public static void SetTextEffect(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.TextEffectKind? value)
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
  public static DocumentModel.Wordprocessing.BorderType? GetBorder(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Border>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBorder(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
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
  public static DocumentModel.Wordprocessing.FitText? GetFitText(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FitTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFitText(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.FitText? value)
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
  public static DocumentModel.Wordprocessing.VerticalPositionKind? GetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
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
  
  public static void SetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalPositionKind? value)
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
  public static Boolean? GetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightToLeftText>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRightToLeftText(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  public static DocumentModel.Wordprocessing.EmphasisMarkKind? GetEmphasis(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
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
  
  public static void SetEmphasis(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.EmphasisMarkKind? value)
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
  public static DocumentModel.Wordprocessing.LanguageType? GetLanguages(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Languages>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLanguages(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
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
  public static DocumentModel.Wordprocessing.EastAsianLayout? GetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, DocumentModel.Wordprocessing.EastAsianLayout? value)
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
  public static Boolean? GetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Wordprocessing.NumberingSymbolRunProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingSymbolRunProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingSymbolRunProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
