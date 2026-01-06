namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the languages used for spell checking and grammar checking in different script contexts.
/// </summary>
/// <remarks>
///   <para>
///   LanguageType defines language codes for three different script contexts:
///   <list type="bullet">
///     <item><description>Latin/ASCII text (most Western languages)</description></item>
///     <item><description>East Asian text (Chinese, Japanese, Korean, etc.)</description></item>
///     <item><description>Complex script text (Arabic, Hebrew, Thai, etc.)</description></item>
///   </list>
///   </para>
///   <para>
///   Language codes should follow RFC 1766 or ISO 639 standards (e.g., "en-US", "ja-JP", "ar-SA").
///   These language settings are used to determine:
///   <list type="bullet">
///     <item><description>Which spell checking and grammar checking dictionaries to use</description></item>
///     <item><description>Hyphenation rules</description></item>
///     <item><description>Sorting and text comparison behavior</description></item>
///     <item><description>Theme font mapping (when used in ThemeFontLanguages context)</description></item>
///   </list>
///   </para>
///   <para>
///   This interface corresponds to the DocumentFormat.OpenXml.Wordprocessing.LanguageType abstract class
///   and is used by both Languages (run properties) and ThemeFontLanguages (document settings) elements.
///   </para>
/// </remarks>
public interface LanguageType
{
  /// <summary>
  ///   Gets or sets the language code for Latin/ASCII text.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the language used for spell checking and grammar checking of text in the Latin/ASCII
  ///   character range (typically Western European languages).
  ///   </para>
  ///   <para>
  ///   Language codes should follow RFC 1766 format (e.g., "en-US", "fr-FR", "de-DE", "es-ES").
  ///   If omitted, the default language from document settings is used.
  ///   </para>
  ///   <para>
  ///   When used in ThemeFontLanguages context, this value determines which theme font definition
  ///   is used for the majorAscii/majorHAnsi and minorAscii/minorHAnsi theme font references.
  ///   </para>
  /// </remarks>
  public string? Val { get; set; }

  /// <summary>
  ///   Gets or sets the language code for East Asian text.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the language used for spell checking and grammar checking of East Asian text
  ///   (Chinese, Japanese, Korean, and other CJK languages).
  ///   </para>
  ///   <para>
  ///   Common East Asian language codes include:
  ///   <list type="bullet">
  ///     <item><description>"zh-CN" - Simplified Chinese (China)</description></item>
  ///     <item><description>"zh-TW" - Traditional Chinese (Taiwan)</description></item>
  ///     <item><description>"ja-JP" - Japanese (Japan)</description></item>
  ///     <item><description>"ko-KR" - Korean (Korea)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   When used in ThemeFontLanguages context, this value determines which theme font definition
  ///   is used for the majorEastAsia and minorEastAsia theme font references.
  ///   </para>
  /// </remarks>
  public string? EastAsia { get; set; }

  /// <summary>
  ///   Gets or sets the language code for complex script (bidirectional) text.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the language used for spell checking and grammar checking of complex script text,
  ///   which typically includes right-to-left (RTL) and bidirectional languages.
  ///   </para>
  ///   <para>
  ///   Common complex script language codes include:
  ///   <list type="bullet">
  ///     <item><description>"ar-SA" - Arabic (Saudi Arabia)</description></item>
  ///     <item><description>"he-IL" - Hebrew (Israel)</description></item>
  ///     <item><description>"th-TH" - Thai (Thailand)</description></item>
  ///     <item><description>"hi-IN" - Hindi (India)</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   When used in ThemeFontLanguages context, this value determines which theme font definition
  ///   is used for the majorBidi and minorBidi theme font references.
  ///   </para>
  /// </remarks>
  public string? Bidi { get; set; }
}