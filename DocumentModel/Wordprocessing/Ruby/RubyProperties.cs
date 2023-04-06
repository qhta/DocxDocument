namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Phonetic Guide Properties.
/// </summary>
public class RubyProperties: ModelElement
{
  /// <summary>
  ///   Phonetic Guide Text Alignment.
  /// </summary>
  public RubyAlignKind? RubyAlign { get; set; }

  /// <summary>
  ///   Phonetic Guide Text Font Size.
  /// </summary>
  public String? PhoneticGuideTextFontSize { get; set; }

  /// <summary>
  ///   Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise { get; set; }

  /// <summary>
  ///   Phonetic Guide Base Text Font Size.
  /// </summary>
  public String? PhoneticGuideBaseTextSize { get; set; }

  /// <summary>
  ///   Language ID for Phonetic Guide.
  /// </summary>
  public String? LanguageId { get; set; }

  /// <summary>
  ///   Invalidated Field Cache.
  /// </summary>
  public Boolean? Dirty { get; set; }
}