namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetSmtClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }
  
  private static void SetSmtClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmtClean = null;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static UInt32? GetSmtId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmtId?.Value;
  }
  
  private static void SetSmtId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmtId = value;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  private static Boolean? GetKumimoji(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }
  
  private static void SetKumimoji(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Kumimoji = null;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  private static String? GetAlternativeLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.AlternativeLanguage?.Value;
  }
  
  private static void SetAlternativeLanguage(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternativeLanguage = new StringValue { Value = value };
    else
      openXmlElement.AlternativeLanguage = null;
  }
  
  /// <summary>
  /// sz
  /// </summary>
  private static Int32? GetFontSize(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.FontSize?.Value;
  }
  
  private static void SetFontSize(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// b
  /// </summary>
  private static Boolean? GetBold(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }
  
  private static void SetBold(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Bold = null;
  }
  
  /// <summary>
  /// i
  /// </summary>
  private static Boolean? GetItalic(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }
  
  private static void SetItalic(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Italic = null;
  }
  
  /// <summary>
  /// u
  /// </summary>
  private static DocumentModel.Drawings.TextUnderlineKind? GetUnderline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }
  
  private static void SetUnderline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, DocumentModel.Drawings.TextUnderlineKind? value)
  {
    openXmlElement.Underline = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues, DocumentModel.Drawings.TextUnderlineKind>(value);
  }
  
  /// <summary>
  /// strike
  /// </summary>
  private static DocumentModel.Drawings.TextStrikeKind? GetStrike(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(openXmlElement?.Strike?.Value);
  }
  
  private static void SetStrike(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, DocumentModel.Drawings.TextStrikeKind? value)
  {
    openXmlElement.Strike = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues, DocumentModel.Drawings.TextStrikeKind>(value);
  }
  
  /// <summary>
  /// kern
  /// </summary>
  private static Int32? GetKerning(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Kerning?.Value;
  }
  
  private static void SetKerning(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Kerning = value;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  private static DocumentModel.Drawings.TextCapsKind? GetCapital(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(openXmlElement?.Capital?.Value);
  }
  
  private static void SetCapital(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, DocumentModel.Drawings.TextCapsKind? value)
  {
    openXmlElement.Capital = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues, DocumentModel.Drawings.TextCapsKind>(value);
  }
  
  /// <summary>
  /// spc
  /// </summary>
  private static Int32? GetSpacing(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Spacing?.Value;
  }
  
  private static void SetSpacing(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Spacing = value;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  private static Boolean? GetNormalizeHeight(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }
  
  private static void SetNormalizeHeight(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NormalizeHeight = null;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  private static Int32? GetBaseline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.Baseline?.Value;
  }
  
  private static void SetBaseline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Baseline = value;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  private static Boolean? GetNoProof(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }
  
  private static void SetNoProof(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoProof = null;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  private static Boolean? GetDirty(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  private static void SetDirty(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// err
  /// </summary>
  private static Boolean? GetSpellingError(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }
  
  private static void SetSpellingError(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SpellingError = null;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  private static Boolean? GetSmartTagClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }
  
  private static void SetSmartTagClean(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SmartTagClean = null;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  private static UInt32? GetSmartTagId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement.SmartTagId?.Value;
  }
  
  private static void SetSmartTagId(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, UInt32? value)
  {
    openXmlElement.SmartTagId = value;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  private static String? GetBookmark(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    return openXmlElement?.Bookmark?.Value;
  }
  
  private static void SetBookmark(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bookmark = new StringValue { Value = value };
    else
      openXmlElement.Bookmark = null;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  private static DocumentModel.Drawings.Outline? GetOutline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OutlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOutline(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType openXmlElement, DocumentModel.Drawings.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.TextCharacterPropertiesType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextCharacterPropertiesType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextCharacterPropertiesType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType, new()
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
