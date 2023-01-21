namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetSmtClean(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }
  
  private static void SetSmtClean(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmtClean = null;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static UInt32? GetSmtId(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmtId?.Value;
  }
  
  private static void SetSmtId(DXDraw.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmtId = value;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  private static Boolean? GetKumimoji(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }
  
  private static void SetKumimoji(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Kumimoji = null;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DXDraw.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  private static String? GetAlternativeLanguage(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.AlternativeLanguage?.Value;
  }
  
  private static void SetAlternativeLanguage(DXDraw.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternativeLanguage = new StringValue { Value = value };
    else
      openXmlElement.AlternativeLanguage = null;
  }
  
  /// <summary>
  /// sz
  /// </summary>
  private static Int32? GetFontSize(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.FontSize?.Value;
  }
  
  private static void SetFontSize(DXDraw.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// b
  /// </summary>
  private static Boolean? GetBold(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }
  
  private static void SetBold(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Bold = null;
  }
  
  /// <summary>
  /// i
  /// </summary>
  private static Boolean? GetItalic(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }
  
  private static void SetItalic(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Italic = null;
  }
  
  /// <summary>
  /// u
  /// </summary>
  private static DMDraws.TextUnderlineKind? GetUnderline(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMDraws.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  private static void SetUnderline(DXDraw.TextCharacterPropertiesType openXmlElement, DMDraws.TextUnderlineKind? value)
  {
    openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DMDraws.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  private static DMDraws.TextStrikeKind? GetStrike(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMDraws.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  private static void SetStrike(DXDraw.TextCharacterPropertiesType openXmlElement, DMDraws.TextStrikeKind? value)
  {
    openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DMDraws.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  private static Int32? GetKerning(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Kerning?.Value;
  }
  
  private static void SetKerning(DXDraw.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Kerning = value;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  private static DMDraws.TextCapsKind? GetCapital(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMDraws.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  private static void SetCapital(DXDraw.TextCharacterPropertiesType openXmlElement, DMDraws.TextCapsKind? value)
  {
    openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DMDraws.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  private static Int32? GetSpacing(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Spacing?.Value;
  }
  
  private static void SetSpacing(DXDraw.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Spacing = value;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  private static Boolean? GetNormalizeHeight(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }
  
  private static void SetNormalizeHeight(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NormalizeHeight = null;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  private static Int32? GetBaseline(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Baseline?.Value;
  }
  
  private static void SetBaseline(DXDraw.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Baseline = value;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  private static Boolean? GetNoProof(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }
  
  private static void SetNoProof(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoProof = null;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  private static Boolean? GetDirty(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  private static void SetDirty(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// err
  /// </summary>
  private static Boolean? GetSpellingError(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }
  
  private static void SetSpellingError(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SpellingError = null;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  private static Boolean? GetSmartTagClean(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }
  
  private static void SetSmartTagClean(DXDraw.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmartTagClean = null;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  private static UInt32? GetSmartTagId(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmartTagId?.Value;
  }
  
  private static void SetSmartTagId(DXDraw.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmartTagId = value;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  private static String? GetBookmark(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bookmark?.Value;
  }
  
  private static void SetBookmark(DXDraw.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bookmark = new StringValue { Value = value };
    else
      openXmlElement.Bookmark = null;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static DMDraws.Outline? GetOutline(DXDraw.TextCharacterPropertiesType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      return DMXDraws.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOutline(DXDraw.TextCharacterPropertiesType openXmlElement, DMDraws.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OutlineConverter.CreateOpenXmlElement<DXDraw.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.TextCharacterPropertiesType? CreateModelElement(DXDraw.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TextCharacterPropertiesType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TextCharacterPropertiesType? value)
    where OpenXmlElementType: DXDraw.TextCharacterPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
