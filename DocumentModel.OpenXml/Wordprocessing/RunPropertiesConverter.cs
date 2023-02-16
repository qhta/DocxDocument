namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  private static String? GetRunStyle(DXW.RunProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val?.Value;
  }
  
  private static bool CmpRunStyle(DXW.RunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.RunStyle>()?.Val?.Value == value;
  }
  
  private static void SetRunStyle(DXW.RunProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.RunStyle { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  private static DMW.RunFonts? GetRunFonts(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunFonts>();
    if (element != null)
      return DMXW.RunFontsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunFonts(DXW.RunProperties openXmlElement, DMW.RunFonts? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunFontsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunFonts>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunFonts(DXW.RunProperties openXmlElement, DMW.RunFonts? value)
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
  private static Boolean? GetBold(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Bold>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBold(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBold(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Bold", val, value);
    return false;
  }
  
  private static void SetBold(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetBoldComplexScript(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.BoldComplexScript>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBoldComplexScript(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBoldComplexScript(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BoldComplexScript", val, value);
    return false;
  }
  
  private static void SetBoldComplexScript(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetItalic(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Italic>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpItalic(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetItalic(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Italic", val, value);
    return false;
  }
  
  private static void SetItalic(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetItalicComplexScript(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.ItalicComplexScript>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpItalicComplexScript(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetItalicComplexScript(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ItalicComplexScript", val, value);
    return false;
  }
  
  private static void SetItalicComplexScript(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetCaps(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Caps>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpCaps(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetCaps(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Caps", val, value);
    return false;
  }
  
  private static void SetCaps(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetSmallCaps(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SmallCaps>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSmallCaps(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSmallCaps(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SmallCaps", val, value);
    return false;
  }
  
  private static void SetSmallCaps(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetStrike(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Strike>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpStrike(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetStrike(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Strike", val, value);
    return false;
  }
  
  private static void SetStrike(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetDoubleStrike(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoubleStrike>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoubleStrike(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoubleStrike(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoubleStrike", val, value);
    return false;
  }
  
  private static void SetDoubleStrike(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetOutline(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Outline>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpOutline(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetOutline(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Outline", val, value);
    return false;
  }
  
  private static void SetOutline(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetShadow(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Shadow>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpShadow(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetShadow(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Shadow", val, value);
    return false;
  }
  
  private static void SetShadow(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetEmboss(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Emboss>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpEmboss(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetEmboss(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Emboss", val, value);
    return false;
  }
  
  private static void SetEmboss(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetImprint(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Imprint>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpImprint(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetImprint(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Imprint", val, value);
    return false;
  }
  
  private static void SetImprint(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetNoProof(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.NoProof>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpNoProof(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetNoProof(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoProof", val, value);
    return false;
  }
  
  private static void SetNoProof(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetSnapToGrid(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSnapToGrid(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSnapToGrid(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SnapToGrid", val, value);
    return false;
  }
  
  private static void SetSnapToGrid(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetVanish(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Vanish>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpVanish(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetVanish(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Vanish", val, value);
    return false;
  }
  
  private static void SetVanish(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetWebHidden(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.WebHidden>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpWebHidden(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetWebHidden(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.WebHidden", val, value);
    return false;
  }
  
  private static void SetWebHidden(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static DMW.Color? GetColor(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Color>();
    if (element != null)
      return DMXW.ColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColor(DXW.RunProperties openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColor(DXW.RunProperties openXmlElement, DMW.Color? value)
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
  private static Int32? GetSpacing(DXW.RunProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val?.Value;
  }
  
  private static bool CmpSpacing(DXW.RunProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Spacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.Spacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSpacing(DXW.RunProperties openXmlElement, Int32? value)
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
  private static Int64? GetCharacterScale(DXW.RunProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val?.Value;
  }
  
  private static bool CmpCharacterScale(DXW.RunProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CharacterScale>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.CharacterScale", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetCharacterScale(DXW.RunProperties openXmlElement, Int64? value)
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
  private static UInt32? GetKern(DXW.RunProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.Kern>()?.Val?.Value;
  }
  
  private static bool CmpKern(DXW.RunProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Kern>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.Kern", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetKern(DXW.RunProperties openXmlElement, UInt32? value)
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
  private static String? GetPosition(DXW.RunProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.Position>()?.Val?.Value;
  }
  
  private static bool CmpPosition(DXW.RunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.Position>()?.Val?.Value == value;
  }
  
  private static void SetPosition(DXW.RunProperties openXmlElement, String? value)
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
  private static String? GetFontSize(DXW.RunProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val?.Value;
  }
  
  private static bool CmpFontSize(DXW.RunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val?.Value == value;
  }
  
  private static void SetFontSize(DXW.RunProperties openXmlElement, String? value)
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
  private static String? GetFontSizeComplexScript(DXW.RunProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val?.Value;
  }
  
  private static bool CmpFontSizeComplexScript(DXW.RunProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val?.Value == value;
  }
  
  private static void SetFontSizeComplexScript(DXW.RunProperties openXmlElement, String? value)
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
  /// Highlight.
  /// </summary>
  private static DMW.HighlightColorKind? GetHighlight(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value);
  }
  
  private static bool CmpHighlight(DXW.RunProperties openXmlElement, DMW.HighlightColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(openXmlElement.GetFirstChild<DXW.Highlight>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHighlight(DXW.RunProperties openXmlElement, DMW.HighlightColorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Highlight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Highlight, DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  private static DMW.Underline? GetUnderline(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Underline>();
    if (element != null)
      return DMXW.UnderlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderline(DXW.RunProperties openXmlElement, DMW.Underline? value, DiffList? diffs, string? objName)
  {
    return DMXW.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Underline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnderline(DXW.RunProperties openXmlElement, DMW.Underline? value)
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
  private static DMW.TextEffectKind? GetTextEffect(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
  }
  
  private static bool CmpTextEffect(DXW.RunProperties openXmlElement, DMW.TextEffectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextEffect(DXW.RunProperties openXmlElement, DMW.TextEffectKind? value)
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
  private static DMW.BorderType? GetBorder(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Border>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorder(DXW.RunProperties openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Border>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorder(DXW.RunProperties openXmlElement, DMW.BorderType? value)
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
  private static DMW.Shading? GetShading(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.RunProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.RunProperties openXmlElement, DMW.Shading? value)
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
  private static DMW.FitText? GetFitText(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FitText>();
    if (element != null)
      return DMXW.FitTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFitText(DXW.RunProperties openXmlElement, DMW.FitText? value, DiffList? diffs, string? objName)
  {
    return DMXW.FitTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FitText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFitText(DXW.RunProperties openXmlElement, DMW.FitText? value)
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
  private static DMW.VerticalPositionKind? GetVerticalTextAlignment(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpVerticalTextAlignment(DXW.RunProperties openXmlElement, DMW.VerticalPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalTextAlignment(DXW.RunProperties openXmlElement, DMW.VerticalPositionKind? value)
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
  private static Boolean? GetRightToLeftText(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.RightToLeftText>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpRightToLeftText(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetRightToLeftText(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.RightToLeftText", val, value);
    return false;
  }
  
  private static void SetRightToLeftText(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static Boolean? GetComplexScript(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.ComplexScript>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpComplexScript(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetComplexScript(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ComplexScript", val, value);
    return false;
  }
  
  private static void SetComplexScript(DXW.RunProperties openXmlElement, Boolean? value)
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
  private static DMW.EmphasisMarkKind? GetEmphasis(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
  }
  
  private static bool CmpEmphasis(DXW.RunProperties openXmlElement, DMW.EmphasisMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmphasis(DXW.RunProperties openXmlElement, DMW.EmphasisMarkKind? value)
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
  private static DMW.LanguageType? GetLanguages(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Languages>();
    if (element != null)
      return DMXW.LanguageTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLanguages(DXW.RunProperties openXmlElement, DMW.LanguageType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Languages>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLanguages(DXW.RunProperties openXmlElement, DMW.LanguageType? value)
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
  private static DMW.EastAsianLayout? GetEastAsianLayout(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EastAsianLayout>();
    if (element != null)
      return DMXW.EastAsianLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianLayout(DXW.RunProperties openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.EastAsianLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EastAsianLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEastAsianLayout(DXW.RunProperties openXmlElement, DMW.EastAsianLayout? value)
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
  private static Boolean? GetSpecVanish(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SpecVanish>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSpecVanish(DXW.RunProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSpecVanish(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SpecVanish", val, value);
    return false;
  }
  
  private static void SetSpecVanish(DXW.RunProperties openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Glow? GetGlow(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Glow>();
    if (element != null)
      return DMXW.GlowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGlow(DXW.RunProperties openXmlElement, DMW.Glow? value, DiffList? diffs, string? objName)
  {
    return DMXW.GlowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Glow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGlow(DXW.RunProperties openXmlElement, DMW.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GlowConverter.CreateOpenXmlElement<DXO2010W.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Shadow2? GetShadow14(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Shadow>();
    if (element != null)
      return DMXW.Shadow2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow14(DXW.RunProperties openXmlElement, DMW.Shadow2? value, DiffList? diffs, string? objName)
  {
    return DMXW.Shadow2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Shadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShadow14(DXW.RunProperties openXmlElement, DMW.Shadow2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Shadow2Converter.CreateOpenXmlElement<DXO2010W.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Reflection? GetReflection(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Reflection>();
    if (element != null)
      return DMXW.ReflectionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpReflection(DXW.RunProperties openXmlElement, DMW.Reflection? value, DiffList? diffs, string? objName)
  {
    return DMXW.ReflectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Reflection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetReflection(DXW.RunProperties openXmlElement, DMW.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ReflectionConverter.CreateOpenXmlElement<DXO2010W.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TextOutlineEffect? GetTextOutlineEffect(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (element != null)
      return DMXW.TextOutlineEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextOutlineEffect(DXW.RunProperties openXmlElement, DMW.TextOutlineEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextOutlineEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextOutlineEffect(DXW.RunProperties openXmlElement, DMW.TextOutlineEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.TextOutlineEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextOutlineEffectConverter.CreateOpenXmlElement<DXO2010W.TextOutlineEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.FillTextEffect? GetFillTextEffect(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.FillTextEffect>();
    if (element != null)
      return DMXW.FillTextEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillTextEffect(DXW.RunProperties openXmlElement, DMW.FillTextEffect? value, DiffList? diffs, string? objName)
  {
    return DMXW.FillTextEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillTextEffect(DXW.RunProperties openXmlElement, DMW.FillTextEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.FillTextEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FillTextEffectConverter.CreateOpenXmlElement<DXO2010W.FillTextEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Scene3D? GetScene3D(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Scene3D>();
    if (element != null)
      return DMXW.Scene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3D(DXW.RunProperties openXmlElement, DMW.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Scene3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3D(DXW.RunProperties openXmlElement, DMW.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Scene3DConverter.CreateOpenXmlElement<DXO2010W.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Properties3D? GetProperties3D(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.Properties3D>();
    if (element != null)
      return DMXW.Properties3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProperties3D(DXW.RunProperties openXmlElement, DMW.Properties3D? value, DiffList? diffs, string? objName)
  {
    return DMXW.Properties3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.Properties3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProperties3D(DXW.RunProperties openXmlElement, DMW.Properties3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Properties3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Properties3DConverter.CreateOpenXmlElement<DXO2010W.Properties3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.LigaturesKind? GetLigatures(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value);
  }
  
  private static bool CmpLigatures(DXW.RunProperties openXmlElement, DMW.LigaturesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(openXmlElement.GetFirstChild<DXO2010W.Ligatures>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLigatures(DXW.RunProperties openXmlElement, DMW.LigaturesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Ligatures>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW.LigaturesKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.NumberFormKind? GetNumberingFormat(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value);
  }
  
  private static bool CmpNumberingFormat(DXW.RunProperties openXmlElement, DMW.NumberFormKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXW.RunProperties openXmlElement, DMW.NumberFormKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW.NumberFormKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.NumberSpacingKind? GetNumberSpacing(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value);
  }
  
  private static bool CmpNumberSpacing(DXW.RunProperties openXmlElement, DMW.NumberSpacingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberSpacing(DXW.RunProperties openXmlElement, DMW.NumberSpacingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NumberSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW.NumberSpacingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.StylisticSets? GetStylisticSets(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.StylisticSets>();
    if (element != null)
      return DMXW.StylisticSetsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStylisticSets(DXW.RunProperties openXmlElement, DMW.StylisticSets? value, DiffList? diffs, string? objName)
  {
    return DMXW.StylisticSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.StylisticSets>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStylisticSets(DXW.RunProperties openXmlElement, DMW.StylisticSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.StylisticSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StylisticSetsConverter.CreateOpenXmlElement<DXO2010W.StylisticSets>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.OnOffKind? GetContextualAlternatives(DXW.RunProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value);
  }
  
  private static bool CmpContextualAlternatives(DXW.RunProperties openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContextualAlternatives(DXW.RunProperties openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.ContextualAlternatives>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2010W.ContextualAlternatives, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  private static DMW.RunPropertiesChange? GetRunPropertiesChange(DXW.RunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesChange>();
    if (element != null)
      return DMXW.RunPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunPropertiesChange(DXW.RunProperties openXmlElement, DMW.RunPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunPropertiesChange(DXW.RunProperties openXmlElement, DMW.RunPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesChangeConverter.CreateOpenXmlElement<DXW.RunPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.RunProperties? CreateModelElement(DXW.RunProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.RunProperties? openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunStyle(openXmlElement, value.RunStyle, diffs, objName))
        ok = false;
      if (!CmpRunFonts(openXmlElement, value.RunFonts, diffs, objName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName))
        ok = false;
      if (!CmpBoldComplexScript(openXmlElement, value.BoldComplexScript, diffs, objName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName))
        ok = false;
      if (!CmpItalicComplexScript(openXmlElement, value.ItalicComplexScript, diffs, objName))
        ok = false;
      if (!CmpCaps(openXmlElement, value.Caps, diffs, objName))
        ok = false;
      if (!CmpSmallCaps(openXmlElement, value.SmallCaps, diffs, objName))
        ok = false;
      if (!CmpStrike(openXmlElement, value.Strike, diffs, objName))
        ok = false;
      if (!CmpDoubleStrike(openXmlElement, value.DoubleStrike, diffs, objName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpEmboss(openXmlElement, value.Emboss, diffs, objName))
        ok = false;
      if (!CmpImprint(openXmlElement, value.Imprint, diffs, objName))
        ok = false;
      if (!CmpNoProof(openXmlElement, value.NoProof, diffs, objName))
        ok = false;
      if (!CmpSnapToGrid(openXmlElement, value.SnapToGrid, diffs, objName))
        ok = false;
      if (!CmpVanish(openXmlElement, value.Vanish, diffs, objName))
        ok = false;
      if (!CmpWebHidden(openXmlElement, value.WebHidden, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpSpacing(openXmlElement, value.Spacing, diffs, objName))
        ok = false;
      if (!CmpCharacterScale(openXmlElement, value.CharacterScale, diffs, objName))
        ok = false;
      if (!CmpKern(openXmlElement, value.Kern, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpFontSizeComplexScript(openXmlElement, value.FontSizeComplexScript, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName))
        ok = false;
      if (!CmpTextEffect(openXmlElement, value.TextEffect, diffs, objName))
        ok = false;
      if (!CmpBorder(openXmlElement, value.Border, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpFitText(openXmlElement, value.FitText, diffs, objName))
        ok = false;
      if (!CmpVerticalTextAlignment(openXmlElement, value.VerticalTextAlignment, diffs, objName))
        ok = false;
      if (!CmpRightToLeftText(openXmlElement, value.RightToLeftText, diffs, objName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, value.ComplexScript, diffs, objName))
        ok = false;
      if (!CmpEmphasis(openXmlElement, value.Emphasis, diffs, objName))
        ok = false;
      if (!CmpLanguages(openXmlElement, value.Languages, diffs, objName))
        ok = false;
      if (!CmpEastAsianLayout(openXmlElement, value.EastAsianLayout, diffs, objName))
        ok = false;
      if (!CmpSpecVanish(openXmlElement, value.SpecVanish, diffs, objName))
        ok = false;
      if (!CmpGlow(openXmlElement, value.Glow, diffs, objName))
        ok = false;
      if (!CmpShadow14(openXmlElement, value.Shadow14, diffs, objName))
        ok = false;
      if (!CmpReflection(openXmlElement, value.Reflection, diffs, objName))
        ok = false;
      if (!CmpTextOutlineEffect(openXmlElement, value.TextOutlineEffect, diffs, objName))
        ok = false;
      if (!CmpFillTextEffect(openXmlElement, value.FillTextEffect, diffs, objName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName))
        ok = false;
      if (!CmpProperties3D(openXmlElement, value.Properties3D, diffs, objName))
        ok = false;
      if (!CmpLigatures(openXmlElement, value.Ligatures, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpNumberSpacing(openXmlElement, value.NumberSpacing, diffs, objName))
        ok = false;
      if (!CmpStylisticSets(openXmlElement, value.StylisticSets, diffs, objName))
        ok = false;
      if (!CmpContextualAlternatives(openXmlElement, value.ContextualAlternatives, diffs, objName))
        ok = false;
      if (!CmpRunPropertiesChange(openXmlElement, value.RunPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunProperties? value)
    where OpenXmlElementType: DXW.RunProperties, new()
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
