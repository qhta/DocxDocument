namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public static class StyleRunPropertiesConverter
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunFonts? GetRunFonts(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunFonts>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunFontsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunFonts(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.RunFonts? value)
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
  public static Boolean? GetBold(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Bold>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBold(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BoldComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBoldComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalic(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Italic>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalic(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ItalicComplexScript>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetItalicComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetCaps(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Caps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetCaps(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SmallCaps>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSmallCaps(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetStrike(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Strike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetStrike(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoubleStrike>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoubleStrike(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetOutline(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Outline>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOutline(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetShadow(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shadow>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetEmboss(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emboss>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetEmboss(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetImprint(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Imprint>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetImprint(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoProof(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoProof>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoProof(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSnapToGrid(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetVanish(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Vanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVanish(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static Boolean? GetWebHidden(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebHidden>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWebHidden(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  public static DocumentModel.Wordprocessing.Color? GetColor(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.Color? value)
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
  public static Int32? GetSpacing(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Spacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetSpacing(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public static Int64? GetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterScale>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetCharacterScale(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public static UInt32? GetKern(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kern>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetKern(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Position>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public static String? GetFontSize(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetFontSize(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public static String? GetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSizeComplexScript>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetFontSizeComplexScript(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public static DocumentModel.Wordprocessing.Underline? GetUnderline(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Underline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.UnderlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnderline(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.Underline? value)
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
  public static DocumentModel.Wordprocessing.TextEffectKind? GetTextEffect(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
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
  
  public static void SetTextEffect(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.TextEffectKind? value)
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
  public static DocumentModel.Wordprocessing.BorderType? GetBorder(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Border>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBorder(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.BorderType? value)
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
  public static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShading(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.Shading? value)
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
  public static DocumentModel.Wordprocessing.FitText? GetFitText(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FitText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FitTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFitText(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.FitText? value)
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
  public static DocumentModel.Wordprocessing.VerticalPositionKind? GetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
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
  
  public static void SetVerticalTextAlignment(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalPositionKind? value)
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
  /// Emphasis.
  /// </summary>
  public static DocumentModel.Wordprocessing.EmphasisMarkKind? GetEmphasis(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
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
  
  public static void SetEmphasis(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.EmphasisMarkKind? value)
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
  public static DocumentModel.Wordprocessing.LanguageType? GetLanguages(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Languages>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LanguageTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLanguages(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.LanguageType? value)
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
  public static DocumentModel.Wordprocessing.EastAsianLayout? GetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EastAsianLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianLayout(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.EastAsianLayout? value)
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
  public static Boolean? GetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpecVanish>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSpecVanish(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, Boolean? value)
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
  /// RunPropertiesChange.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunPropertiesChange? GetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement, DocumentModel.Wordprocessing.RunPropertiesChange? value)
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
  
  public static DocumentModel.Wordprocessing.StyleRunProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StyleRunProperties();
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
      value.Emphasis = GetEmphasis(openXmlElement);
      value.Languages = GetLanguages(openXmlElement);
      value.EastAsianLayout = GetEastAsianLayout(openXmlElement);
      value.SpecVanish = GetSpecVanish(openXmlElement);
      value.RunPropertiesChange = GetRunPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StyleRunProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.StyleRunProperties, new()
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
      SetEmphasis(openXmlElement, value?.Emphasis);
      SetLanguages(openXmlElement, value?.Languages);
      SetEastAsianLayout(openXmlElement, value?.EastAsianLayout);
      SetSpecVanish(openXmlElement, value?.SpecVanish);
      SetRunPropertiesChange(openXmlElement, value?.RunPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}
