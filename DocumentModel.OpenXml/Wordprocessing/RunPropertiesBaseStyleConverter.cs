namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesBaseStyleConverter
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  private static DMW.RunFonts? GetRunFonts(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.RunFontsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RunFonts>());
  }
  
  private static bool CmpRunFonts(DXW.RunPropertiesBaseStyle openXmlElement, DMW.RunFonts? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunFontsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunFonts>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunFonts(DXW.RunPropertiesBaseStyle openXmlElement, DMW.RunFonts? value)
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
  private static Boolean? GetBold(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Bold>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBold(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBold(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Bold", val, value);
    return false;
  }
  
  private static void SetBold(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetBoldComplexScript(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.BoldComplexScript>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBoldComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBoldComplexScript(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BoldComplexScript", val, value);
    return false;
  }
  
  private static void SetBoldComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetItalic(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Italic>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpItalic(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetItalic(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Italic", val, value);
    return false;
  }
  
  private static void SetItalic(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetItalicComplexScript(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.ItalicComplexScript>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpItalicComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetItalicComplexScript(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ItalicComplexScript", val, value);
    return false;
  }
  
  private static void SetItalicComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetCaps(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Caps>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpCaps(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetCaps(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Caps", val, value);
    return false;
  }
  
  private static void SetCaps(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetSmallCaps(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SmallCaps>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSmallCaps(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSmallCaps(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SmallCaps", val, value);
    return false;
  }
  
  private static void SetSmallCaps(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetStrike(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Strike>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpStrike(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetStrike(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Strike", val, value);
    return false;
  }
  
  private static void SetStrike(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetDoubleStrike(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoubleStrike>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDoubleStrike(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDoubleStrike(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoubleStrike", val, value);
    return false;
  }
  
  private static void SetDoubleStrike(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetOutline(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Outline>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpOutline(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetOutline(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Outline", val, value);
    return false;
  }
  
  private static void SetOutline(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetShadow(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Shadow>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpShadow(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetShadow(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Shadow", val, value);
    return false;
  }
  
  private static void SetShadow(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetEmboss(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Emboss>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpEmboss(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetEmboss(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Emboss", val, value);
    return false;
  }
  
  private static void SetEmboss(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetImprint(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Imprint>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpImprint(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetImprint(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Imprint", val, value);
    return false;
  }
  
  private static void SetImprint(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetNoProof(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.NoProof>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpNoProof(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetNoProof(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.NoProof", val, value);
    return false;
  }
  
  private static void SetNoProof(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetSnapToGrid(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSnapToGrid(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSnapToGrid(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SnapToGrid", val, value);
    return false;
  }
  
  private static void SetSnapToGrid(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetVanish(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Vanish>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpVanish(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetVanish(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Vanish", val, value);
    return false;
  }
  
  private static void SetVanish(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static Boolean? GetWebHidden(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.WebHidden>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpWebHidden(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetWebHidden(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.WebHidden", val, value);
    return false;
  }
  
  private static void SetWebHidden(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  private static DMW.Color? GetColor(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.ColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Color>());
  }
  
  private static bool CmpColor(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Color? value, DiffList? diffs, string? objName)
  {
    return DMXW.ColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Color>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColor(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Color? value)
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
  private static Int32? GetSpacing(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.Spacing>()?.Val?.Value;
  }
  
  private static bool CmpSpacing(DXW.RunPropertiesBaseStyle openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Spacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.Spacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSpacing(DXW.RunPropertiesBaseStyle openXmlElement, Int32? value)
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
  private static Int64? GetCharacterScale(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.CharacterScale>()?.Val?.Value;
  }
  
  private static bool CmpCharacterScale(DXW.RunPropertiesBaseStyle openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.CharacterScale>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.CharacterScale", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetCharacterScale(DXW.RunPropertiesBaseStyle openXmlElement, Int64? value)
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
  private static UInt32? GetKern(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.Kern>()?.Val?.Value;
  }
  
  private static bool CmpKern(DXW.RunPropertiesBaseStyle openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Kern>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.Kern", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetKern(DXW.RunPropertiesBaseStyle openXmlElement, UInt32? value)
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
  private static String? GetPosition(DXW.RunPropertiesBaseStyle openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.Position>()?.Val?.Value;
  }
  
  private static bool CmpPosition(DXW.RunPropertiesBaseStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.Position>()?.Val?.Value == value;
  }
  
  private static void SetPosition(DXW.RunPropertiesBaseStyle openXmlElement, String? value)
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
  private static String? GetFontSize(DXW.RunPropertiesBaseStyle openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val?.Value;
  }
  
  private static bool CmpFontSize(DXW.RunPropertiesBaseStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSize>()?.Val?.Value == value;
  }
  
  private static void SetFontSize(DXW.RunPropertiesBaseStyle openXmlElement, String? value)
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
  private static String? GetFontSizeComplexScript(DXW.RunPropertiesBaseStyle openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val?.Value;
  }
  
  private static bool CmpFontSizeComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FontSizeComplexScript>()?.Val?.Value == value;
  }
  
  private static void SetFontSizeComplexScript(DXW.RunPropertiesBaseStyle openXmlElement, String? value)
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
  private static DMW.Underline? GetUnderline(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.UnderlineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Underline>());
  }
  
  private static bool CmpUnderline(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Underline? value, DiffList? diffs, string? objName)
  {
    return DMXW.UnderlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Underline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnderline(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Underline? value)
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
  private static DMW.TextEffectKind? GetTextEffect(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
  }
  
  private static bool CmpTextEffect(DXW.RunPropertiesBaseStyle openXmlElement, DMW.TextEffectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(openXmlElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextEffect(DXW.RunPropertiesBaseStyle openXmlElement, DMW.TextEffectKind? value)
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
  private static DMW.BorderType? GetBorder(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Border>());
  }
  
  private static bool CmpBorder(DXW.RunPropertiesBaseStyle openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Border>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorder(DXW.RunPropertiesBaseStyle openXmlElement, DMW.BorderType? value)
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
  private static DMW.Shading? GetShading(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.ShadingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Shading>());
  }
  
  private static bool CmpShading(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.RunPropertiesBaseStyle openXmlElement, DMW.Shading? value)
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
  private static DMW.FitText? GetFitText(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.FitTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FitText>());
  }
  
  private static bool CmpFitText(DXW.RunPropertiesBaseStyle openXmlElement, DMW.FitText? value, DiffList? diffs, string? objName)
  {
    return DMXW.FitTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FitText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFitText(DXW.RunPropertiesBaseStyle openXmlElement, DMW.FitText? value)
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
  private static DMW.VerticalPositionKind? GetVerticalTextAlignment(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpVerticalTextAlignment(DXW.RunPropertiesBaseStyle openXmlElement, DMW.VerticalPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(openXmlElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalTextAlignment(DXW.RunPropertiesBaseStyle openXmlElement, DMW.VerticalPositionKind? value)
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
  /// Emphasis.
  /// </summary>
  private static DMW.EmphasisMarkKind? GetEmphasis(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
  }
  
  private static bool CmpEmphasis(DXW.RunPropertiesBaseStyle openXmlElement, DMW.EmphasisMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(openXmlElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEmphasis(DXW.RunPropertiesBaseStyle openXmlElement, DMW.EmphasisMarkKind? value)
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
  private static DMW.LanguageType? GetLanguages(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.LanguageTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Languages>());
  }
  
  private static bool CmpLanguages(DXW.RunPropertiesBaseStyle openXmlElement, DMW.LanguageType? value, DiffList? diffs, string? objName)
  {
    return DMXW.LanguageTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Languages>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLanguages(DXW.RunPropertiesBaseStyle openXmlElement, DMW.LanguageType? value)
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
  private static DMW.EastAsianLayout? GetEastAsianLayout(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    return DMXW.EastAsianLayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EastAsianLayout>());
  }
  
  private static bool CmpEastAsianLayout(DXW.RunPropertiesBaseStyle openXmlElement, DMW.EastAsianLayout? value, DiffList? diffs, string? objName)
  {
    return DMXW.EastAsianLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EastAsianLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEastAsianLayout(DXW.RunPropertiesBaseStyle openXmlElement, DMW.EastAsianLayout? value)
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
  private static Boolean? GetSpecVanish(DXW.RunPropertiesBaseStyle openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.SpecVanish>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpSpecVanish(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetSpecVanish(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SpecVanish", val, value);
    return false;
  }
  
  private static void SetSpecVanish(DXW.RunPropertiesBaseStyle openXmlElement, Boolean? value)
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
  
  public static DMW.RunPropertiesBaseStyle? CreateModelElement(DXW.RunPropertiesBaseStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunPropertiesBaseStyle();
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
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RunPropertiesBaseStyle? openXmlElement, DMW.RunPropertiesBaseStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
      if (!CmpEmphasis(openXmlElement, value.Emphasis, diffs, objName))
        ok = false;
      if (!CmpLanguages(openXmlElement, value.Languages, diffs, objName))
        ok = false;
      if (!CmpEastAsianLayout(openXmlElement, value.EastAsianLayout, diffs, objName))
        ok = false;
      if (!CmpSpecVanish(openXmlElement, value.SpecVanish, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesBaseStyle? value)
    where OpenXmlElementType: DXW.RunPropertiesBaseStyle, new()
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
      return openXmlElement;
    }
    return default;
  }
}
