namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetSmtClean(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }
  
  private static bool CmpSmtClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmtClean?.Value == value) return true;
    diffs?.Add(objName, "SmtClean", openXmlElement?.SmtClean?.Value, value);
    return false;
  }
  
  private static void SetSmtClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmtClean = null;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static UInt32? GetSmtId(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtId?.Value;
  }
  
  private static bool CmpSmtId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmtId?.Value == value) return true;
    diffs?.Add(objName, "SmtId", openXmlElement?.SmtId?.Value, value);
    return false;
  }
  
  private static void SetSmtId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmtId = value;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  private static Boolean? GetKumimoji(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }
  
  private static bool CmpKumimoji(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Kumimoji?.Value == value) return true;
    diffs?.Add(objName, "Kumimoji", openXmlElement?.Kumimoji?.Value, value);
    return false;
  }
  
  private static void SetKumimoji(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Kumimoji = null;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Languages");
  }
  
  private static void SetLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  private static String? GetAlternativeLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternativeLanguage);
  }
  
  private static bool CmpAlternativeLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternativeLanguage, value, diffs, objName, "AlternativeLanguage");
  }
  
  private static void SetAlternativeLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.AlternativeLanguage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sz
  /// </summary>
  private static Int32? GetFontSize(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }
  
  private static bool CmpFontSize(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FontSize?.Value == value) return true;
    diffs?.Add(objName, "FontSize", openXmlElement?.FontSize?.Value, value);
    return false;
  }
  
  private static void SetFontSize(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// b
  /// </summary>
  private static Boolean? GetBold(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }
  
  private static bool CmpBold(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bold?.Value == value) return true;
    diffs?.Add(objName, "Bold", openXmlElement?.Bold?.Value, value);
    return false;
  }
  
  private static void SetBold(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Bold = null;
  }
  
  /// <summary>
  /// i
  /// </summary>
  private static Boolean? GetItalic(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }
  
  private static bool CmpItalic(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Italic?.Value == value) return true;
    diffs?.Add(objName, "Italic", openXmlElement?.Italic?.Value, value);
    return false;
  }
  
  private static void SetItalic(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Italic = null;
  }
  
  /// <summary>
  /// u
  /// </summary>
  private static DMD.TextUnderlineKind? GetUnderline(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  private static bool CmpUnderline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextUnderlineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(openXmlElement?.Underline?.Value, value, diffs, objName, propName);
  }
  
  private static void SetUnderline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextUnderlineKind? value)
  {
    openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  private static DMD.TextStrikeKind? GetStrike(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  private static bool CmpStrike(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextStrikeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(openXmlElement?.Strike?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStrike(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextStrikeKind? value)
  {
    openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  private static Int32? GetKerning(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kerning?.Value;
  }
  
  private static bool CmpKerning(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Kerning?.Value == value) return true;
    diffs?.Add(objName, "Kerning", openXmlElement?.Kerning?.Value, value);
    return false;
  }
  
  private static void SetKerning(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Kerning = value;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  private static DMD.TextCapsKind? GetCapital(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  private static bool CmpCapital(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextCapsKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(openXmlElement?.Capital?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCapital(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextCapsKind? value)
  {
    openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  private static Int32? GetSpacing(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Spacing?.Value;
  }
  
  private static bool CmpSpacing(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Spacing?.Value == value) return true;
    diffs?.Add(objName, "Spacing", openXmlElement?.Spacing?.Value, value);
    return false;
  }
  
  private static void SetSpacing(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Spacing = value;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  private static Boolean? GetNormalizeHeight(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }
  
  private static bool CmpNormalizeHeight(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NormalizeHeight?.Value == value) return true;
    diffs?.Add(objName, "NormalizeHeight", openXmlElement?.NormalizeHeight?.Value, value);
    return false;
  }
  
  private static void SetNormalizeHeight(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NormalizeHeight = null;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  private static Int32? GetBaseline(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Baseline?.Value;
  }
  
  private static bool CmpBaseline(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Baseline?.Value == value) return true;
    diffs?.Add(objName, "Baseline", openXmlElement?.Baseline?.Value, value);
    return false;
  }
  
  private static void SetBaseline(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Baseline = value;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  private static Boolean? GetNoProof(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }
  
  private static bool CmpNoProof(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoProof?.Value == value) return true;
    diffs?.Add(objName, "NoProof", openXmlElement?.NoProof?.Value, value);
    return false;
  }
  
  private static void SetNoProof(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoProof = null;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  private static Boolean? GetDirty(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  private static bool CmpDirty(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dirty?.Value == value) return true;
    diffs?.Add(objName, "Dirty", openXmlElement?.Dirty?.Value, value);
    return false;
  }
  
  private static void SetDirty(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// err
  /// </summary>
  private static Boolean? GetSpellingError(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }
  
  private static bool CmpSpellingError(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SpellingError?.Value == value) return true;
    diffs?.Add(objName, "SpellingError", openXmlElement?.SpellingError?.Value, value);
    return false;
  }
  
  private static void SetSpellingError(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SpellingError = null;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  private static Boolean? GetSmartTagClean(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }
  
  private static bool CmpSmartTagClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmartTagClean?.Value == value) return true;
    diffs?.Add(objName, "SmartTagClean", openXmlElement?.SmartTagClean?.Value, value);
    return false;
  }
  
  private static void SetSmartTagClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmartTagClean = null;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  private static UInt32? GetSmartTagId(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagId?.Value;
  }
  
  private static bool CmpSmartTagId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmartTagId?.Value == value) return true;
    diffs?.Add(objName, "SmartTagId", openXmlElement?.SmartTagId?.Value, value);
    return false;
  }
  
  private static void SetSmartTagId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmartTagId = value;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  private static String? GetBookmark(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Bookmark);
  }
  
  private static bool CmpBookmark(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Bookmark, value, diffs, objName, "Bookmark");
  }
  
  private static void SetBookmark(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.Bookmark = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static DMD.LineProperties? GetOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName, propName);
  }
  
  private static void SetOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.LineProperties? value)
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
  
  private static DMD.EffectList? GetEffectList(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectList? value)
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
  
  private static DMD.EffectDag? GetEffectDag(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectDag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectDag? value)
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
  
  private static DMD.Highlight? GetHighlight(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Highlight>();
    if (element != null)
      return DMXD.HighlightConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighlight(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Highlight? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HighlightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Highlight>(), value, diffs, objName, propName);
  }
  
  private static void SetHighlight(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Highlight? value)
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
  
  private static Boolean? GetUnderlineFollowsText(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
  }
  
  private static bool CmpUnderlineFollowsText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFollowsText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFollowsText", val, value);
    return false;
  }
  
  private static void SetUnderlineFollowsText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
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
  
  private static Boolean? GetUnderlineFillText(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
  }
  
  private static bool CmpUnderlineFillText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.UnderlineFillText>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.UnderlineFillText", val, value);
    return false;
  }
  
  private static void SetUnderlineFillText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
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
  
  private static DMD.Fill? GetUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UnderlineFill>();
    if (element != null)
      return DMXD.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Fill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UnderlineFill>(), value, diffs, objName, propName);
  }
  
  private static void SetUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Fill? value)
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
  
  private static DMD.TextFontType? GetLatinFont(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LatinFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLatinFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), value, diffs, objName, propName);
  }
  
  private static void SetLatinFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetEastAsianFont(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EastAsianFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), value, diffs, objName, propName);
  }
  
  private static void SetEastAsianFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetComplexScriptFont(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ComplexScriptFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComplexScriptFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), value, diffs, objName, propName);
  }
  
  private static void SetComplexScriptFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.TextFontType? GetSymbolFont(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SymbolFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSymbolFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SymbolFont>(), value, diffs, objName, propName);
  }
  
  private static void SetSymbolFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value)
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
  
  private static DMD.HyperlinkOnClick? GetHyperlinkOnClick(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnClick>();
    if (element != null)
      return DMXD.HyperlinkOnClickConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnClick(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnClick(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnClick? value)
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
  
  private static DMD.HyperlinkOnMouseOver? GetHyperlinkOnMouseOver(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HyperlinkOnMouseOver>();
    if (element != null)
      return DMXD.HyperlinkOnMouseOverConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkOnMouseOver(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnMouseOver? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlinkOnMouseOver(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnMouseOver? value)
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
  
  private static Boolean? GetRightToLeft(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
  }
  
  private static bool CmpRightToLeft(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.RightToLeft>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.RightToLeft", val, value);
    return false;
  }
  
  private static void SetRightToLeft(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
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
  
  private static DMD.ExtensionList? GetExtensionList(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCS.TextCharacterPropertiesType? CreateModelElement(DXO13DCS.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDCS.TextCharacterPropertiesType();
      model.SmtClean = GetSmtClean(openXmlElement);
      model.SmtId = GetSmtId(openXmlElement);
      model.Kumimoji = GetKumimoji(openXmlElement);
      model.Language = GetLanguage(openXmlElement);
      model.AlternativeLanguage = GetAlternativeLanguage(openXmlElement);
      model.FontSize = GetFontSize(openXmlElement);
      model.Bold = GetBold(openXmlElement);
      model.Italic = GetItalic(openXmlElement);
      model.Underline = GetUnderline(openXmlElement);
      model.Strike = GetStrike(openXmlElement);
      model.Kerning = GetKerning(openXmlElement);
      model.Capital = GetCapital(openXmlElement);
      model.Spacing = GetSpacing(openXmlElement);
      model.NormalizeHeight = GetNormalizeHeight(openXmlElement);
      model.Baseline = GetBaseline(openXmlElement);
      model.NoProof = GetNoProof(openXmlElement);
      model.Dirty = GetDirty(openXmlElement);
      model.SpellingError = GetSpellingError(openXmlElement);
      model.SmartTagClean = GetSmartTagClean(openXmlElement);
      model.SmartTagId = GetSmartTagId(openXmlElement);
      model.Bookmark = GetBookmark(openXmlElement);
      model.Outline = GetOutline(openXmlElement);
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      model.EffectList = GetEffectList(openXmlElement);
      model.EffectDag = GetEffectDag(openXmlElement);
      model.Highlight = GetHighlight(openXmlElement);
      model.UnderlineFollowsText = GetUnderlineFollowsText(openXmlElement);
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
  
  public static bool CompareModelElement(DXO13DCS.TextCharacterPropertiesType? openXmlElement, DMDCS.TextCharacterPropertiesType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpSmtClean(openXmlElement, model.SmtClean, diffs, objName, propName))
        ok = false;
      if (!CmpSmtId(openXmlElement, model.SmtId, diffs, objName, propName))
        ok = false;
      if (!CmpKumimoji(openXmlElement, model.Kumimoji, diffs, objName, propName))
        ok = false;
      if (!CmpLanguage(openXmlElement, model.Language, diffs, objName, propName))
        ok = false;
      if (!CmpAlternativeLanguage(openXmlElement, model.AlternativeLanguage, diffs, objName, propName))
        ok = false;
      if (!CmpFontSize(openXmlElement, model.FontSize, diffs, objName, propName))
        ok = false;
      if (!CmpBold(openXmlElement, model.Bold, diffs, objName, propName))
        ok = false;
      if (!CmpItalic(openXmlElement, model.Italic, diffs, objName, propName))
        ok = false;
      if (!CmpUnderline(openXmlElement, model.Underline, diffs, objName, propName))
        ok = false;
      if (!CmpStrike(openXmlElement, model.Strike, diffs, objName, propName))
        ok = false;
      if (!CmpKerning(openXmlElement, model.Kerning, diffs, objName, propName))
        ok = false;
      if (!CmpCapital(openXmlElement, model.Capital, diffs, objName, propName))
        ok = false;
      if (!CmpSpacing(openXmlElement, model.Spacing, diffs, objName, propName))
        ok = false;
      if (!CmpNormalizeHeight(openXmlElement, model.NormalizeHeight, diffs, objName, propName))
        ok = false;
      if (!CmpBaseline(openXmlElement, model.Baseline, diffs, objName, propName))
        ok = false;
      if (!CmpNoProof(openXmlElement, model.NoProof, diffs, objName, propName))
        ok = false;
      if (!CmpDirty(openXmlElement, model.Dirty, diffs, objName, propName))
        ok = false;
      if (!CmpSpellingError(openXmlElement, model.SpellingError, diffs, objName, propName))
        ok = false;
      if (!CmpSmartTagClean(openXmlElement, model.SmartTagClean, diffs, objName, propName))
        ok = false;
      if (!CmpSmartTagId(openXmlElement, model.SmartTagId, diffs, objName, propName))
        ok = false;
      if (!CmpBookmark(openXmlElement, model.Bookmark, diffs, objName, propName))
        ok = false;
      if (!CmpOutline(openXmlElement, model.Outline, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpEffectList(openXmlElement, model.EffectList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, model.EffectDag, diffs, objName, propName))
        ok = false;
      if (!CmpHighlight(openXmlElement, model.Highlight, diffs, objName, propName))
        ok = false;
      if (!CmpUnderlineFollowsText(openXmlElement, model.UnderlineFollowsText, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.TextCharacterPropertiesType model)
    where OpenXmlElementType: DXO13DCS.TextCharacterPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMDCS.TextCharacterPropertiesType model)
  {
    SetSmtClean(openXmlElement, model.SmtClean);
    SetSmtId(openXmlElement, model.SmtId);
    SetKumimoji(openXmlElement, model.Kumimoji);
    SetLanguage(openXmlElement, model.Language);
    SetAlternativeLanguage(openXmlElement, model.AlternativeLanguage);
    SetFontSize(openXmlElement, model.FontSize);
    SetBold(openXmlElement, model.Bold);
    SetItalic(openXmlElement, model.Italic);
    SetUnderline(openXmlElement, model.Underline);
    SetStrike(openXmlElement, model.Strike);
    SetKerning(openXmlElement, model.Kerning);
    SetCapital(openXmlElement, model.Capital);
    SetSpacing(openXmlElement, model.Spacing);
    SetNormalizeHeight(openXmlElement, model.NormalizeHeight);
    SetBaseline(openXmlElement, model.Baseline);
    SetNoProof(openXmlElement, model.NoProof);
    SetDirty(openXmlElement, model.Dirty);
    SetSpellingError(openXmlElement, model.SpellingError);
    SetSmartTagClean(openXmlElement, model.SmartTagClean);
    SetSmartTagId(openXmlElement, model.SmartTagId);
    SetBookmark(openXmlElement, model.Bookmark);
    SetOutline(openXmlElement, model.Outline);
    FillConverter.UpdateOpenXmlElement(openXmlElement, model.Fill);
    SetEffectList(openXmlElement, model.EffectList);
    SetEffectDag(openXmlElement, model.EffectDag);
    SetHighlight(openXmlElement, model.Highlight);
    SetUnderlineFollowsText(openXmlElement, model.UnderlineFollowsText);
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
