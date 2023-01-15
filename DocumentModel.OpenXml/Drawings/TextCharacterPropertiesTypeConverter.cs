using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Outline = DocumentModel.Drawings.Outline;
using TextCharacterPropertiesType = DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public static class TextCharacterPropertiesTypeConverter
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static Boolean? GetSmtClean(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmtClean?.Value;
  }

  public static void SetSmtClean(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SmtClean = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SmtClean = null;
  }

  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public static UInt32? GetSmtId(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmtId?.Value;
  }

  public static void SetSmtId(TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SmtId = value;
  }

  /// <summary>
  ///   kumimoji
  /// </summary>
  public static Boolean? GetKumimoji(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Kumimoji?.Value;
  }

  public static void SetKumimoji(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Kumimoji = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Kumimoji = null;
  }

  /// <summary>
  ///   lang
  /// </summary>
  public static String? GetLanguage(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }

  public static void SetLanguage(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Language = new StringValue { Value = value };
      else
        openXmlElement.Language = null;
  }

  /// <summary>
  ///   altLang
  /// </summary>
  public static String? GetAlternativeLanguage(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.AlternativeLanguage?.Value;
  }

  public static void SetAlternativeLanguage(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternativeLanguage = new StringValue { Value = value };
      else
        openXmlElement.AlternativeLanguage = null;
  }

  /// <summary>
  ///   sz
  /// </summary>
  public static Int32? GetFontSize(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }

  public static void SetFontSize(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontSize = value;
  }

  /// <summary>
  ///   b
  /// </summary>
  public static Boolean? GetBold(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Bold?.Value;
  }

  public static void SetBold(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bold = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Bold = null;
  }

  /// <summary>
  ///   i
  /// </summary>
  public static Boolean? GetItalic(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Italic?.Value;
  }

  public static void SetItalic(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Italic = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Italic = null;
  }

  /// <summary>
  ///   u
  /// </summary>
  public static TextUnderlineKind? GetUnderline(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextUnderlineValues, TextUnderlineKind>(openXmlElement?.Underline?.Value);
  }

  public static void SetUnderline(TextCharacterPropertiesType? openXmlElement, TextUnderlineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Underline = EnumValueConverter.CreateEnumValue<TextUnderlineValues, TextUnderlineKind>(value);
  }

  /// <summary>
  ///   strike
  /// </summary>
  public static TextStrikeKind? GetStrike(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextStrikeValues, TextStrikeKind>(openXmlElement?.Strike?.Value);
  }

  public static void SetStrike(TextCharacterPropertiesType? openXmlElement, TextStrikeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Strike = EnumValueConverter.CreateEnumValue<TextStrikeValues, TextStrikeKind>(value);
  }

  /// <summary>
  ///   kern
  /// </summary>
  public static Int32? GetKerning(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Kerning?.Value;
  }

  public static void SetKerning(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Kerning = value;
  }

  /// <summary>
  ///   cap
  /// </summary>
  public static TextCapsKind? GetCapital(TextCharacterPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextCapsValues, TextCapsKind>(openXmlElement?.Capital?.Value);
  }

  public static void SetCapital(TextCharacterPropertiesType? openXmlElement, TextCapsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Capital = EnumValueConverter.CreateEnumValue<TextCapsValues, TextCapsKind>(value);
  }

  /// <summary>
  ///   spc
  /// </summary>
  public static Int32? GetSpacing(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Spacing?.Value;
  }

  public static void SetSpacing(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Spacing = value;
  }

  /// <summary>
  ///   normalizeH
  /// </summary>
  public static Boolean? GetNormalizeHeight(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.NormalizeHeight?.Value;
  }

  public static void SetNormalizeHeight(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NormalizeHeight = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NormalizeHeight = null;
  }

  /// <summary>
  ///   baseline
  /// </summary>
  public static Int32? GetBaseline(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Baseline?.Value;
  }

  public static void SetBaseline(TextCharacterPropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Baseline = value;
  }

  /// <summary>
  ///   noProof
  /// </summary>
  public static Boolean? GetNoProof(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.NoProof?.Value;
  }

  public static void SetNoProof(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoProof = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoProof = null;
  }

  /// <summary>
  ///   dirty
  /// </summary>
  public static Boolean? GetDirty(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }

  public static void SetDirty(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Dirty = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Dirty = null;
  }

  /// <summary>
  ///   err
  /// </summary>
  public static Boolean? GetSpellingError(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SpellingError?.Value;
  }

  public static void SetSpellingError(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SpellingError = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SpellingError = null;
  }

  /// <summary>
  ///   smtClean
  /// </summary>
  public static Boolean? GetSmartTagClean(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmartTagClean?.Value;
  }

  public static void SetSmartTagClean(TextCharacterPropertiesType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SmartTagClean = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SmartTagClean = null;
  }

  /// <summary>
  ///   smtId
  /// </summary>
  public static UInt32? GetSmartTagId(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.SmartTagId?.Value;
  }

  public static void SetSmartTagId(TextCharacterPropertiesType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SmartTagId = value;
  }

  /// <summary>
  ///   bmk
  /// </summary>
  public static String? GetBookmark(TextCharacterPropertiesType? openXmlElement)
  {
    return openXmlElement?.Bookmark?.Value;
  }

  public static void SetBookmark(TextCharacterPropertiesType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Bookmark = new StringValue { Value = value };
      else
        openXmlElement.Bookmark = null;
  }

  /// <summary>
  ///   Outline.
  /// </summary>
  public static Outline? GetOutline(TextCharacterPropertiesType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
    if (itemElement != null)
      return OutlineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOutline(TextCharacterPropertiesType? openXmlElement, Outline? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Outline>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.TextCharacterPropertiesType? CreateModelElement(TextCharacterPropertiesType? openXmlElement)
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
    where OpenXmlElementType : TextCharacterPropertiesType, new()
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