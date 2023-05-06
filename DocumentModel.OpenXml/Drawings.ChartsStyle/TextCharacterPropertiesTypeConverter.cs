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
  
  private static bool CmpSmtClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpSmtId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpKumimoji(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpAlternativeLanguage(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpFontSize(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpBold(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpItalic(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpUnderline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextUnderlineKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(openXmlElement?.Underline?.Value, value, diffs, objName);
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
  
  private static bool CmpStrike(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextStrikeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(openXmlElement?.Strike?.Value, value, diffs, objName);
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
  
  private static bool CmpKerning(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpCapital(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextCapsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(openXmlElement?.Capital?.Value, value, diffs, objName);
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
  
  private static bool CmpSpacing(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpNormalizeHeight(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpBaseline(DXO13DCS.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpNoProof(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpDirty(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpSpellingError(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpSmartTagClean(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpSmartTagId(DXO13DCS.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpBookmark(DXO13DCS.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs, string? objName)
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
  private static DMD.Outline? GetOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXD.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName);
  }
  
  private static void SetOutline(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.NoFill();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SolidFill? GetSolidFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.GradientFill? GetGradientFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BlipFill? GetBlipFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipFill>();
    if (element != null)
      return DMXD.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipFill>(), value, diffs, objName);
  }
  
  private static void SetBlipFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetGroupFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.GroupFill();
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
  
  private static bool CmpEffectList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName);
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
  
  private static bool CmpEffectDag(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName);
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
  
  private static bool CmpHighlight(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.Highlight? value, DiffList? diffs, string? objName)
  {
    return DMXD.HighlightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Highlight>(), value, diffs, objName);
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
  
  private static bool CmpUnderlineFollowsText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpUnderlineFillText(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static DMD.UnderlineFill? GetUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.UnderlineFill>();
    if (element != null)
      return DMXD.UnderlineFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.UnderlineFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.UnderlineFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.UnderlineFill>(), value, diffs, objName);
  }
  
  private static void SetUnderlineFill(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.UnderlineFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.UnderlineFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.UnderlineFillConverter.CreateOpenXmlElement<DXD.UnderlineFill>(value);
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
  
  private static bool CmpLatinFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), value, diffs, objName);
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
  
  private static bool CmpEastAsianFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), value, diffs, objName);
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
  
  private static bool CmpComplexScriptFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), value, diffs, objName);
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
  
  private static bool CmpSymbolFont(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SymbolFont>(), value, diffs, objName);
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
  
  private static bool CmpHyperlinkOnClick(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnClick? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkOnClickConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnClick>(), value, diffs, objName);
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
  
  private static bool CmpHyperlinkOnMouseOver(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.HyperlinkOnMouseOver? value, DiffList? diffs, string? objName)
  {
    return DMXD.HyperlinkOnMouseOverConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HyperlinkOnMouseOver>(), value, diffs, objName);
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
  
  private static bool CmpRightToLeft(DXO13DCS.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpExtensionList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? CreateModelElement(DXO13DCS.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType();
      value.SmtClean = GetSmtClean(openXmlElement);
      value.SmtId = GetSmtId(openXmlElement);
      value.Kumimoji = GetKumimoji(openXmlElement);
      value.Language = GetLanguage(openXmlElement);
      value.AlternativeLanguage = GetAlternativeLanguage(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.Bold = GetBold(openXmlElement);
      value.Italic = GetItalic(openXmlElement);
      value.Underline = GetUnderline(openXmlElement);
      value.Strike = GetStrike(openXmlElement);
      value.Kerning = GetKerning(openXmlElement);
      value.Capital = GetCapital(openXmlElement);
      value.Spacing = GetSpacing(openXmlElement);
      value.NormalizeHeight = GetNormalizeHeight(openXmlElement);
      value.Baseline = GetBaseline(openXmlElement);
      value.NoProof = GetNoProof(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.SpellingError = GetSpellingError(openXmlElement);
      value.SmartTagClean = GetSmartTagClean(openXmlElement);
      value.SmartTagId = GetSmartTagId(openXmlElement);
      value.Bookmark = GetBookmark(openXmlElement);
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
  
  public static bool CompareModelElement(DXO13DCS.TextCharacterPropertiesType? openXmlElement, DMDCS.TextCharacterPropertiesType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSmtClean(openXmlElement, value.SmtClean, diffs, objName))
        ok = false;
      if (!CmpSmtId(openXmlElement, value.SmtId, diffs, objName))
        ok = false;
      if (!CmpKumimoji(openXmlElement, value.Kumimoji, diffs, objName))
        ok = false;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpAlternativeLanguage(openXmlElement, value.AlternativeLanguage, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName))
        ok = false;
      if (!CmpStrike(openXmlElement, value.Strike, diffs, objName))
        ok = false;
      if (!CmpKerning(openXmlElement, value.Kerning, diffs, objName))
        ok = false;
      if (!CmpCapital(openXmlElement, value.Capital, diffs, objName))
        ok = false;
      if (!CmpSpacing(openXmlElement, value.Spacing, diffs, objName))
        ok = false;
      if (!CmpNormalizeHeight(openXmlElement, value.NormalizeHeight, diffs, objName))
        ok = false;
      if (!CmpBaseline(openXmlElement, value.Baseline, diffs, objName))
        ok = false;
      if (!CmpNoProof(openXmlElement, value.NoProof, diffs, objName))
        ok = false;
      if (!CmpDirty(openXmlElement, value.Dirty, diffs, objName))
        ok = false;
      if (!CmpSpellingError(openXmlElement, value.SpellingError, diffs, objName))
        ok = false;
      if (!CmpSmartTagClean(openXmlElement, value.SmartTagClean, diffs, objName))
        ok = false;
      if (!CmpSmartTagId(openXmlElement, value.SmartTagId, diffs, objName))
        ok = false;
      if (!CmpBookmark(openXmlElement, value.Bookmark, diffs, objName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpGroupFill(openXmlElement, value.GroupFill, diffs, objName))
        ok = false;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      if (!CmpHighlight(openXmlElement, value.Highlight, diffs, objName))
        ok = false;
      if (!CmpUnderlineFollowsText(openXmlElement, value.UnderlineFollowsText, diffs, objName))
        ok = false;
      if (!CmpUnderlineFillText(openXmlElement, value.UnderlineFillText, diffs, objName))
        ok = false;
      if (!CmpUnderlineFill(openXmlElement, value.UnderlineFill, diffs, objName))
        ok = false;
      if (!CmpLatinFont(openXmlElement, value.LatinFont, diffs, objName))
        ok = false;
      if (!CmpEastAsianFont(openXmlElement, value.EastAsianFont, diffs, objName))
        ok = false;
      if (!CmpComplexScriptFont(openXmlElement, value.ComplexScriptFont, diffs, objName))
        ok = false;
      if (!CmpSymbolFont(openXmlElement, value.SymbolFont, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnClick(openXmlElement, value.HyperlinkOnClick, diffs, objName))
        ok = false;
      if (!CmpHyperlinkOnMouseOver(openXmlElement, value.HyperlinkOnMouseOver, diffs, objName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, value.RightToLeft, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.TextCharacterPropertiesType value)
    where OpenXmlElementType: DXO13DCS.TextCharacterPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.TextCharacterPropertiesType openXmlElement, DMDCS.TextCharacterPropertiesType value)
  {
    SetSmtClean(openXmlElement, value?.SmtClean);
    SetSmtId(openXmlElement, value?.SmtId);
    SetKumimoji(openXmlElement, value?.Kumimoji);
    SetLanguage(openXmlElement, value?.Language);
    SetAlternativeLanguage(openXmlElement, value?.AlternativeLanguage);
    SetFontSize(openXmlElement, value?.FontSize);
    SetBold(openXmlElement, value?.Bold);
    SetItalic(openXmlElement, value?.Italic);
    SetUnderline(openXmlElement, value?.Underline);
    SetStrike(openXmlElement, value?.Strike);
    SetKerning(openXmlElement, value?.Kerning);
    SetCapital(openXmlElement, value?.Capital);
    SetSpacing(openXmlElement, value?.Spacing);
    SetNormalizeHeight(openXmlElement, value?.NormalizeHeight);
    SetBaseline(openXmlElement, value?.Baseline);
    SetNoProof(openXmlElement, value?.NoProof);
    SetDirty(openXmlElement, value?.Dirty);
    SetSpellingError(openXmlElement, value?.SpellingError);
    SetSmartTagClean(openXmlElement, value?.SmartTagClean);
    SetSmartTagId(openXmlElement, value?.SmartTagId);
    SetBookmark(openXmlElement, value?.Bookmark);
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
  }
}
