namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetSmtClean(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }
  
  private static bool CmpSmtClean(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmtClean?.Value == value) return true;
    diffs?.Add(objName, "SmtClean", openXmlElement?.SmtClean?.Value, value);
    return false;
  }
  
  private static void SetSmtClean(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmtClean = null;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static UInt32? GetSmtId(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtId?.Value;
  }
  
  private static bool CmpSmtId(DXD.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmtId?.Value == value) return true;
    diffs?.Add(objName, "SmtId", openXmlElement?.SmtId?.Value, value);
    return false;
  }
  
  private static void SetSmtId(DXD.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmtId = value;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  private static Boolean? GetKumimoji(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }
  
  private static bool CmpKumimoji(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Kumimoji?.Value == value) return true;
    diffs?.Add(objName, "Kumimoji", openXmlElement?.Kumimoji?.Value, value);
    return false;
  }
  
  private static void SetKumimoji(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Kumimoji = null;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Language);
  }
  
  private static bool CmpLanguage(DXD.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Language, value, diffs, objName, "Languages");
  }
  
  private static void SetLanguage(DXD.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.Language = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  private static String? GetAlternativeLanguage(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternativeLanguage);
  }
  
  private static bool CmpAlternativeLanguage(DXD.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternativeLanguage, value, diffs, objName, "AlternativeLanguage");
  }
  
  private static void SetAlternativeLanguage(DXD.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.AlternativeLanguage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sz
  /// </summary>
  private static Int32? GetFontSize(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }
  
  private static bool CmpFontSize(DXD.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FontSize?.Value == value) return true;
    diffs?.Add(objName, "FontSize", openXmlElement?.FontSize?.Value, value);
    return false;
  }
  
  private static void SetFontSize(DXD.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// b
  /// </summary>
  private static Boolean? GetBold(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }
  
  private static bool CmpBold(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bold?.Value == value) return true;
    diffs?.Add(objName, "Bold", openXmlElement?.Bold?.Value, value);
    return false;
  }
  
  private static void SetBold(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Bold = null;
  }
  
  /// <summary>
  /// i
  /// </summary>
  private static Boolean? GetItalic(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }
  
  private static bool CmpItalic(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Italic?.Value == value) return true;
    diffs?.Add(objName, "Italic", openXmlElement?.Italic?.Value, value);
    return false;
  }
  
  private static void SetItalic(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Italic = null;
  }
  
  /// <summary>
  /// u
  /// </summary>
  private static DMD.TextUnderlineKind? GetUnderline(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  private static bool CmpUnderline(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextUnderlineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(openXmlElement?.Underline?.Value, value, diffs, objName, propName);
  }
  
  private static void SetUnderline(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextUnderlineKind? value)
  {
    openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMD.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  private static DMD.TextStrikeKind? GetStrike(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  private static bool CmpStrike(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextStrikeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(openXmlElement?.Strike?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStrike(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextStrikeKind? value)
  {
    openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMD.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  private static Int32? GetKerning(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kerning?.Value;
  }
  
  private static bool CmpKerning(DXD.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Kerning?.Value == value) return true;
    diffs?.Add(objName, "Kerning", openXmlElement?.Kerning?.Value, value);
    return false;
  }
  
  private static void SetKerning(DXD.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Kerning = value;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  private static DMD.TextCapsKind? GetCapital(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  private static bool CmpCapital(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextCapsKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(openXmlElement?.Capital?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCapital(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextCapsKind? value)
  {
    openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMD.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  private static Int32? GetSpacing(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Spacing?.Value;
  }
  
  private static bool CmpSpacing(DXD.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Spacing?.Value == value) return true;
    diffs?.Add(objName, "Spacing", openXmlElement?.Spacing?.Value, value);
    return false;
  }
  
  private static void SetSpacing(DXD.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Spacing = value;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  private static Boolean? GetNormalizeHeight(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }
  
  private static bool CmpNormalizeHeight(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NormalizeHeight?.Value == value) return true;
    diffs?.Add(objName, "NormalizeHeight", openXmlElement?.NormalizeHeight?.Value, value);
    return false;
  }
  
  private static void SetNormalizeHeight(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NormalizeHeight = null;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  private static Int32? GetBaseline(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Baseline?.Value;
  }
  
  private static bool CmpBaseline(DXD.TextCharacterPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Baseline?.Value == value) return true;
    diffs?.Add(objName, "Baseline", openXmlElement?.Baseline?.Value, value);
    return false;
  }
  
  private static void SetBaseline(DXD.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Baseline = value;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  private static Boolean? GetNoProof(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }
  
  private static bool CmpNoProof(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoProof?.Value == value) return true;
    diffs?.Add(objName, "NoProof", openXmlElement?.NoProof?.Value, value);
    return false;
  }
  
  private static void SetNoProof(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoProof = null;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  private static Boolean? GetDirty(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  private static bool CmpDirty(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dirty?.Value == value) return true;
    diffs?.Add(objName, "Dirty", openXmlElement?.Dirty?.Value, value);
    return false;
  }
  
  private static void SetDirty(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// err
  /// </summary>
  private static Boolean? GetSpellingError(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }
  
  private static bool CmpSpellingError(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SpellingError?.Value == value) return true;
    diffs?.Add(objName, "SpellingError", openXmlElement?.SpellingError?.Value, value);
    return false;
  }
  
  private static void SetSpellingError(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SpellingError = null;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  private static Boolean? GetSmartTagClean(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }
  
  private static bool CmpSmartTagClean(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmartTagClean?.Value == value) return true;
    diffs?.Add(objName, "SmartTagClean", openXmlElement?.SmartTagClean?.Value, value);
    return false;
  }
  
  private static void SetSmartTagClean(DXD.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmartTagClean = null;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  private static UInt32? GetSmartTagId(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagId?.Value;
  }
  
  private static bool CmpSmartTagId(DXD.TextCharacterPropertiesType openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SmartTagId?.Value == value) return true;
    diffs?.Add(objName, "SmartTagId", openXmlElement?.SmartTagId?.Value, value);
    return false;
  }
  
  private static void SetSmartTagId(DXD.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmartTagId = value;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  private static String? GetBookmark(DXD.TextCharacterPropertiesType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Bookmark);
  }
  
  private static bool CmpBookmark(DXD.TextCharacterPropertiesType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Bookmark, value, diffs, objName, "Bookmark");
  }
  
  private static void SetBookmark(DXD.TextCharacterPropertiesType openXmlElement, String? value)
  {
    openXmlElement.Bookmark = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static DMD.LineProperties? GetOutline(DXD.TextCharacterPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXD.TextCharacterPropertiesType openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName, propName);
  }
  
  private static void SetOutline(DXD.TextCharacterPropertiesType openXmlElement, DMD.LineProperties? value)
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
  
  public static DMD.TextCharacterPropertiesType? CreateModelElement(DXD.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.TextCharacterPropertiesType();
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
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.TextCharacterPropertiesType? openXmlElement, DMD.TextCharacterPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSmtClean(openXmlElement, value.SmtClean, diffs, objName, propName))
        ok = false;
      if (!CmpSmtId(openXmlElement, value.SmtId, diffs, objName, propName))
        ok = false;
      if (!CmpKumimoji(openXmlElement, value.Kumimoji, diffs, objName, propName))
        ok = false;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName, propName))
        ok = false;
      if (!CmpAlternativeLanguage(openXmlElement, value.AlternativeLanguage, diffs, objName, propName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName, propName))
        ok = false;
      if (!CmpBold(openXmlElement, value.Bold, diffs, objName, propName))
        ok = false;
      if (!CmpItalic(openXmlElement, value.Italic, diffs, objName, propName))
        ok = false;
      if (!CmpUnderline(openXmlElement, value.Underline, diffs, objName, propName))
        ok = false;
      if (!CmpStrike(openXmlElement, value.Strike, diffs, objName, propName))
        ok = false;
      if (!CmpKerning(openXmlElement, value.Kerning, diffs, objName, propName))
        ok = false;
      if (!CmpCapital(openXmlElement, value.Capital, diffs, objName, propName))
        ok = false;
      if (!CmpSpacing(openXmlElement, value.Spacing, diffs, objName, propName))
        ok = false;
      if (!CmpNormalizeHeight(openXmlElement, value.NormalizeHeight, diffs, objName, propName))
        ok = false;
      if (!CmpBaseline(openXmlElement, value.Baseline, diffs, objName, propName))
        ok = false;
      if (!CmpNoProof(openXmlElement, value.NoProof, diffs, objName, propName))
        ok = false;
      if (!CmpDirty(openXmlElement, value.Dirty, diffs, objName, propName))
        ok = false;
      if (!CmpSpellingError(openXmlElement, value.SpellingError, diffs, objName, propName))
        ok = false;
      if (!CmpSmartTagClean(openXmlElement, value.SmartTagClean, diffs, objName, propName))
        ok = false;
      if (!CmpSmartTagId(openXmlElement, value.SmartTagId, diffs, objName, propName))
        ok = false;
      if (!CmpBookmark(openXmlElement, value.Bookmark, diffs, objName, propName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TextCharacterPropertiesType value)
    where OpenXmlElementType: DXD.TextCharacterPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TextCharacterPropertiesType openXmlElement, DMD.TextCharacterPropertiesType value)
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
  }
}
